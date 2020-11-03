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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();

			Button AddUserButton = new Button();
			AddUserButton.Width = 150;
			AddUserButton.Height = 50;
			AddUserButton.Location = new Point(10, 50);
			AddUserButton.Text = "Add user";

			Button ShowUsersButton = new Button();
			ShowUsersButton.Width = 150;
			ShowUsersButton.Height = 50;
			ShowUsersButton.Location = new Point(10, 125);
			ShowUsersButton.Text = "Add user";

			AddUser AU = new AddUser();

			AddUserButton.Click += (s, p) => {
				AU.ShowDialog();
			};

			ShowUsers SU = new ShowUsers();

			ShowUsersButton.Click += (s, p) => {
				SU.ShowDialog();
			};

			this.Controls.Add(AddUserButton);
			this.Controls.Add(ShowUsersButton);
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			this.Hide();
			this.Close();
        }
    }
}
