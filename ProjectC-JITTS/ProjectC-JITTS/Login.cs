﻿using ProjectC_JITTS.Database;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin CL = new CheckLogin();

            if (CL.TryLogin(txtEmail.Text, txtPassword.Text))
            {
                MessageBox.Show("U bent nu ingelogd");
                this.Close();
            }
            else
            {
                MessageBox.Show("Onjuiste combinatie van Email en wachtwoord, probeer opnieuw");
            }

        }
    }
}