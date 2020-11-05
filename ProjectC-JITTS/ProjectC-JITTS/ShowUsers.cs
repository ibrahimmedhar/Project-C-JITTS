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

            this.Controls.Add(dta);

            string dbstring = "server=localhost;user=root;pwd=admin;database=projectc";
            MySqlConnection connection = new MySqlConnection(dbstring);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT email, permission_level FROM projectc.accounts;", connection);

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
                return;
            };
        }

        public void Remove_User()
        {
            if (dta.SelectedRows.Count > 0 || dta.SelectedCells.Count > 0)
            {
                MessageBox.Show("verwijderen");
            }
            else
            {
                MessageBox.Show("Select a user to remove");
            }
        }
    }
}
