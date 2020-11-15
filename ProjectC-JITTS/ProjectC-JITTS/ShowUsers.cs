using MySql.Data.MySqlClient;
using ProjectC_JITTS.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectC_JITTS
{
    public partial class ShowUsers : Form
    {
        public DataGridView dta = new DataGridView();
        protected string dbstring = "server=localhost;user=root;pwd=admin;database=projectc";
        public ShowUsers()
        {
            InitializeComponent();
            this.Width = 1280;
            RefreshScreen();

        }

        public void RefreshScreen()
        {
            dta.Width = this.Width - 200;
            dta.Height = this.Height;
            dta.Location = new Point(0, 0);
            dta.AllowUserToAddRows = false;

            this.Controls.Add(dta);

            MySqlConnection connection = new MySqlConnection(dbstring);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT name, surname, email, permission_level FROM projectc.accounts;", connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "users");
                dta.DataSource = ds.Tables["users"];
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            Button RemoveUser = new Button();
            RemoveUser.Width = 150;
            RemoveUser.Height = 50;
            RemoveUser.Location = new Point(Width - 175, 25);
            RemoveUser.Text = "Remove User";

            Button EditUser = new Button();
            EditUser.Width = 150;
            EditUser.Height = 50;
            EditUser.Location = new Point(Width - 175, 100);
            EditUser.Text = "Edit User";

            this.Controls.Add(RemoveUser);
            this.Controls.Add(EditUser);

            RemoveUser.Click += (s, p) => {
                Remove_User();
            };
            EditUser.Click += (s, p) => {
                EditSelectedUser();
            };
        }

        private void Remove_User()
        {
            if (dta.SelectedRows.Count > 0 || dta.SelectedCells.Count > 0)
            {
                MySqlConnection connection = new MySqlConnection(dbstring);

                try
                {
                    string query = "DELETE FROM `projectc`.`accounts` WHERE (`email` = '" + dta.SelectedCells[0].Value.ToString() + "');";

                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("User deleted");
                        RefreshScreen();
                    }
                    else
                    {
                        MessageBox.Show("???");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Select a user to remove");
            }
        }

        private void EditSelectedUser()
        {
            int row = dta.CurrentCell.RowIndex;
            string name = dta.Rows[row].Cells[0].Value.ToString();
            string surname = dta.Rows[row].Cells[1].Value.ToString();
            string email = dta.Rows[row].Cells[2].Value.ToString();

            EditUser EU = new EditUser(name, surname, email);
            EU.ShowDialog();

            MySqlConnection connection = new MySqlConnection(dbstring);
            try
            {
                string query = "UPDATE `projectc`.`accounts` SET `email` = '"+ EU.ReturnEmail + "', `name` = '" + EU.ReturnName + "', `surname` = '" + EU.ReturnSurname + "' WHERE (`email` = '" + email +"');";

                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("User editted");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            
            RefreshScreen();
        }
    }
}
