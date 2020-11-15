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

            Button AddUserButton = new Button
            {
                Width = 150,
                Height = 50,
                Location = new Point(10, 50),
                Text = "Add user"
            };


            AddUserButton.Click += (s, p) => {
				AddUser AU = new AddUser();
				AU.ShowDialog();
			};

			this.Controls.Add(AddUserButton);

            Button AddRoomButton = new Button
            {
                Width = 150,
                Height = 50,
                Location = new Point(200, 50),
                Text = "Add room"
            };


            AddRoomButton.Click += (s, p) => {
				AddRoom AR = new AddRoom();
				AR.ShowDialog();
			};

			this.Controls.Add(AddRoomButton);

            Button EditRoomButton = new Button
            {
                Width = 200,
                Height = 50,
                Location = new Point(400, 50),
                Text = "Edit room"
            };


            EditRoomButton.Click += (s, p) => {
				EditRoom ER = new EditRoom();
				ER.ShowDialog();
			};

			this.Controls.Add(EditRoomButton);

            Button RemoveRoomButton = new Button
            {
                Width = 200,
                Height = 50,
                Location = new Point(600, 50),
                Text = "Remove room"
            };


            RemoveRoomButton.Click += (s, p) => {
                RemoveRoom RM = new RemoveRoom();
                RM.ShowDialog();
            };

            this.Controls.Add(RemoveRoomButton);

            Button AddDateButton = new Button
            {
                Width = 200,
                Height = 50,
                Location = new Point(800, 50),
                Text = "Add a new date with workplaces"
            };


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
