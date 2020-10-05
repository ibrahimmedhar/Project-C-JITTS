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

				roomLabel.Location = new Point(0 + x, 120);
				roomLabel.AutoSize = true;

				this.Controls.Add(roomLabel);

				x += 200;
			}
		}
	}
}
