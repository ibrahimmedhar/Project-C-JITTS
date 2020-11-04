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
    public partial class ShowRooms : Form
    {
		public ShowRooms(string roomdate, string location)
		{
			InitializeComponent();

			GetData GD = new GetData();
			AddData AD = new AddData();

			this.AutoScroll = true;
			int x = 20;

			foreach (Tuple<int, string, string, string, string, string, string> room in GD.ShowRoomsByDateAndLoc(roomdate, location))
			{
				Label roomLabel = new Label();
				roomLabel.Width = 150;
				roomLabel.Height = 220;
				roomLabel.BorderStyle = BorderStyle.FixedSingle;
				roomLabel.Cursor = Cursors.Hand;
				roomLabel.Text = "Location name: " + room.Item7;
				roomLabel.Text += "\nRoom no: " + room.Item2;
				roomLabel.Text += "\nWorkplaces : " + room.Item3;
				roomLabel.Text += "\nWorkplaces Available " + room.Item4;
				roomLabel.Text += "\nLocation Key: " + room.Item5;
				roomLabel.Text += "\nDate: " + room.Item6;

				roomLabel.Click += (s, p) => {
					ReserveWorkplace RW = new ReserveWorkplace(room.Item1);
					this.Hide();
					RW.ShowDialog();
					this.Close();
				};

				roomLabel.Location = new Point(0 + x, 120);
				roomLabel.AutoSize = true;

				this.Controls.Add(roomLabel);

				x += 200;
			}
		}

		private void back_btn_Click(object sender, EventArgs e)
        {
			this.Hide();
			this.Close();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowRooms_Load(object sender, EventArgs e)
        {

        }
    }
}
