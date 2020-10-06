using ProjectC_JITTS.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectC_JITTS
{
    public partial class ShowDates : Form
    {
        public ShowDates(string location)
        {
            InitializeComponent();

			GetData GD = new GetData();

			int x = 20;

			foreach (string date in GD.ShowDatesByLocation(location))
			{
				Label dateLabel = new Label();
				dateLabel.Width = 150;
				dateLabel.Height = 200;
				dateLabel.BorderStyle = BorderStyle.FixedSingle;
				dateLabel.Cursor = Cursors.Hand;
				dateLabel.Text = "Date: " + date;

				ShowRooms SR = new ShowRooms(date, location);

				dateLabel.Click += (s, p) => {
					this.Hide();
					SR.ShowDialog();
					this.Close();
				};

				dateLabel.Location = new Point(0 + x, 120);
				dateLabel.AutoSize = true;

				this.Controls.Add(dateLabel);

				x += 200;
			}
		}
    }
}
