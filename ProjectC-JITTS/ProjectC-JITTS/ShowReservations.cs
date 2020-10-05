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
    public partial class ShowReservations : Form
    {
		/// <summary>
		/// Show all reservations in labels
		/// </summary>
		/// <param name="roomnumber"></param>
		/// <param name="location"></param>
        public ShowReservations(string roomnumber, string location)
        {
            InitializeComponent();

			GetData GD = new GetData();
			AddData AD = new AddData();

			this.AutoScroll = true;
			Tuple<string, string, string, string> movieInfo = GD.ShowRoomByNoAndLoc(roomnumber,location);

			Label LB1 = new Label();
			LB1.Text = "Room no selected: " + movieInfo.Item1 + "\n\nWorkplaces: " + movieInfo.Item2 + "\n\nWorkplaces left:  " + movieInfo.Item3 + "\n\nLocation:  " + movieInfo.Item4;
			LB1.MaximumSize = new Size(600, 0);
			LB1.Location = new Point(50, 10);
			LB1.AutoSize = true;
			this.Controls.Add(LB1);

			Button ReserveButton = new Button();
			ReserveButton.Text = "Reserve workplace";
			ReserveButton.Location = new Point(this.Width / 2, this.Height - 20);
			LB1.Location = new Point(50, 80);
			LB1.AutoSize = true;

			ReserveButton.Click += (s, p) =>
			{
				// set the datetime to the right sql format 
				DateTime myDateTime = DateTime.Now;
				string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

				// insert the reservation into the database using AddData
				AD.ReserveWorkplace("Test Subject", Int32.Parse(movieInfo.Item1), movieInfo.Item4, sqlFormattedDate);
				DialogResult result = MessageBox.Show("Reservation Completed", "Dialog Title", MessageBoxButtons.OK);
				if (result == DialogResult.OK)
				{
					Environment.Exit(0);
				}
			};

			this.Controls.Add(ReserveButton);

		}

		private void back_btn_Click(object sender, EventArgs e)
        {
			this.Hide();
			Home form = new Home();
			form.ShowDialog();
			this.Close();
		}
    }
}
