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

			AddUserButton.Click += (s, p) => {
				AddUser AU = new AddUser();
				AU.ShowDialog();
			};

			this.Controls.Add(AddUserButton);

			Button ShowUsersButton = new Button();
			ShowUsersButton.Width = 150;
			ShowUsersButton.Height = 50;
			ShowUsersButton.Location = new Point(10, 150);
			ShowUsersButton.Text = "Show all users";

			ShowUsersButton.Click += (s, p) => {
				ShowUsers SU = new ShowUsers();
				SU.ShowDialog();
			};

			this.Controls.Add(ShowUsersButton);

			Button AddRoomButton = new Button();
			AddRoomButton.Width = 150;
			AddRoomButton.Height = 50;
			AddRoomButton.Location = new Point(200, 50);
			AddRoomButton.Text = "Add room";


			AddRoomButton.Click += (s, p) => {
				AddRoom AR = new AddRoom();
				AR.ShowDialog();
			};

			this.Controls.Add(AddRoomButton);

			Button AddDateButton = new Button();
			AddDateButton.Width = 200;
			AddDateButton.Height = 50;
			AddDateButton.Location = new Point(400, 50);
			AddDateButton.Text = "Add a new date with workplaces";


			AddDateButton.Click += (s, p) => {
				AddDate AD = new AddDate();
				AD.ShowDialog();
			};

			this.Controls.Add(AddDateButton);
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			Form home = new Home();
			this.Hide();
			home.ShowDialog();
			
			this.Close();
        }
    }
}
