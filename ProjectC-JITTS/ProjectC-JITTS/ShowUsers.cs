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
        public ShowUsers()
        {
            InitializeComponent();

            DataGridView dta = new DataGridView();
            dta.Width = this.Width - 100;
            dta.Height = this.Height;
            dta.Location = new Point(0,0);

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

        }
    }
}
