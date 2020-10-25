using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectC_JITTS.Database;

namespace ProjectC_JITTS
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

            /*
            TextBox EmailAddress = new TextBox
            {
                Width = 100,
                Location = new Point(20, 20),
                Text = "eg. user@domain.com"
            };

            this.Controls.Add(EmailAddress);

            TextBox Password = new TextBox
            {
                Width = 100,
                Location = new Point(20, 40),
                Text = "eg. secret123"
            };

            this.Controls.Add(Password);
            */
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool succesInsert;
            if (txtPassword.Text == txtPasswordCheck.Text)
            {
                AddData AD = new AddData();

                if (AdminCheckBox.Checked)
                {
                    succesInsert = AD.AddUser(txtEmail.Text, txtPassword.Text, 3);
                }
                else
                {
                    succesInsert = AD.AddUser(txtEmail.Text, txtPassword.Text, 1);
                }

                if (succesInsert)
                {
                    MessageBox.Show("Toegevoegd");
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mislukt");
                }
            }
            else
            {
                MessageBox.Show("Wachtwoorden komen niet overeen");
            }
        }
    }
}
