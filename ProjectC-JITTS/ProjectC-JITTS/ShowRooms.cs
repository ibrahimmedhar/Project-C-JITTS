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

			foreach (Tuple<string, string, string, string, string> room in GD.ShowRoomsByDateAndLoc(roomdate, location))
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
				roomLabel.Text += "\nDate: " + room.Item5;

				ReserveWorkplace RW = new ReserveWorkplace(room.Item5, room.Item1, room.Item4);

				roomLabel.Click += (s, p) => {
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
			Home form = new Home();
			form.ShowDialog();
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
