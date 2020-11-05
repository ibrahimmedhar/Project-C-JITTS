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
                    MessageBox.Show("Account was added");
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account was not added");
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }
    }
}
