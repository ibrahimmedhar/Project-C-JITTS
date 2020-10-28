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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

			GetData GD = new GetData();

			int x = 20;

			foreach (string location in GD.ShowLocations())
			{
                Label locationLabel = new Label
                {
                    Width = 150,
                    Height = 200,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Text = "Location: " + location
                };

				locationLabel.Click += (s, p) => {
					ShowDates SD = new ShowDates(location);
					SD.ShowDialog();
				};

				locationLabel.Location = new Point(0 + x, 120);
				locationLabel.AutoSize = true;

				this.Controls.Add(locationLabel);

				x += 200;
			}

			// check if permission level is high enough
			if (GetData.LoginInfo.PermissionLevel > 1)
            {
				Button AdminButton = new Button();
				AdminButton.Width = 150;
				AdminButton.Height = 50;
				AdminButton.Location = new Point(this.Width - 10, 50);
				AdminButton.Text = "Admin panel";

				AdminPage AP = new AdminPage();

				AdminButton.Click += (s, p) => {
					this.Hide();
					this.Close();
					AP.ShowDialog();
				};

				this.Controls.Add(AdminButton);
			}
			
		}
	}
}
