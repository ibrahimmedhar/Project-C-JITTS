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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin CL = new CheckLogin();
            GetData GD = new GetData();

            if (CL.TryLogin(txtEmail.text, txtPassword.text))
            {
                // to add the UserID to the application
                Tuple<string, int> accountInfo = GD.ShowAccountInfo(txtEmail.text);

                GetData.LoginInfo.UserID = accountInfo.Item1;
                GetData.LoginInfo.PermissionLevel = accountInfo.Item2;

                Form home = new Home();
                this.Hide();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Onjuiste combinatie van Email en wachtwoord, probeer opnieuw");
            }
        }
    }
}