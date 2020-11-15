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
    public partial class EditUser : Form
    {
        public string ReturnName { get; set; }
        public string ReturnSurname { get; set; }
        public string ReturnEmail { get; set; }


        public EditUser(string name, string surname, string email)
        {
            InitializeComponent();

            txtName.Text = name;
            txtSurname.Text = surname;
            txtEmail.Text = email;
        }

        private void nameSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (txtName.Enabled)
            {
                txtName.Enabled = false;
            }
            else
            {
                txtName.Enabled = true;
            }    
        }

        private void surnameSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (txtSurname.Enabled)
            {
                txtSurname.Enabled = false;
            }
            else
            {
                txtSurname.Enabled = true;
            }
        }

        private void emailSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (txtEmail.Enabled)
            {
                txtEmail.Enabled = false;
            }
            else
            {
                txtEmail.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.ReturnName = txtName.Text.ToString();
            this.ReturnSurname = txtSurname.Text.ToString();
            this.ReturnEmail = txtEmail.Text.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
