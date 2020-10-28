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
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			Form home = new Home();
			home.ShowDialog();
			this.Hide();
			this.Close();
        }
    }
}
