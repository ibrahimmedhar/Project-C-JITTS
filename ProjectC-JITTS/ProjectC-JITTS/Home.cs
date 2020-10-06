﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

			GetData GD = new GetData();

			int x = 20;

			foreach (string location in GD.ShowLocations())
			{
				Label locationLabel = new Label();
				locationLabel.Width = 150;
				locationLabel.Height = 200;
				locationLabel.BorderStyle = BorderStyle.FixedSingle;
				locationLabel.Cursor = Cursors.Hand;
				locationLabel.Text = "Location: " + location;
				
				ShowDates SD = new ShowDates(location);

				locationLabel.Click += (s, p) => {
					this.Hide();
					SD.ShowDialog();
					this.Close();
				};

				locationLabel.Location = new Point(0 + x, 120);
				locationLabel.AutoSize = true;

				this.Controls.Add(locationLabel);

				x += 200;
			}

			/*int x = 20;

			foreach (Tuple<string, string, string, string> room in GD.ShowRooms())
			{
				Label roomLabel = new Label();
				roomLabel.Width = 150;
				roomLabel.Height = 200;
				roomLabel.BorderStyle = BorderStyle.FixedSingle;
				roomLabel.Cursor = Cursors.Hand;
				roomLabel.Text = "Room no: " + room.Item1;
				roomLabel.Text += "\nWorkplaces : " + room.Item2;
				roomLabel.Text += "\nWorkplaces Available " + room.Item3;
				roomLabel.Text += "\nLocation: " + room.Item4;

				ShowRooms SR = new ShowRooms(room.Item1, room.Item4);

				roomLabel.Click += (s, p) => {
					this.Hide();
					SR.ShowDialog();
					this.Close();
				};

				roomLabel.Location = new Point(0 + x, 120);
				roomLabel.AutoSize = true;

				this.Controls.Add(roomLabel);

				x += 200;
			}*/
		}
	}
}
