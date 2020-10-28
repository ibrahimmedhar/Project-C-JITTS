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
				AdminButton.Text = "Admin functies";

				AdminPage AP = new AdminPage();

				AdminButton.Click += (s, p) => {
					AP.ShowDialog();
				};

				this.Controls.Add(AdminButton);
			}
			
		}

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox2_OnTextChange_1(object sender, EventArgs e)
        {

        }
    }
}
