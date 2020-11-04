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
    public partial class ReserveWorkplace : Form
    {
		/// <summary>
		/// Reserve a workplace and show info in labels
		/// </summary>
		/// <param name="roomnumber"></param>
		/// <param name="location"></param>
		public ReserveWorkplace(string roomdate, string roomnumber, string roomloc)
        {
            InitializeComponent();
			

			InitializeComponent();

			GetData GD = new GetData();
			AddData AD = new AddData();

			this.AutoScroll = true;
			Tuple<string, string, string, string, string> roomInfo = GD.ShowRoomByKeys(roomdate, roomnumber, roomloc);

			Label LB1 = new Label();
			LB1.Text = "Room no selected: " + roomInfo.Item1 + "\n\nWorkplaces: " + roomInfo.Item2 + "\n\nWorkplaces left:  " + roomInfo.Item3 + "\n\nLocation:  " + roomInfo.Item4 + "\nDate:	" + roomInfo.Item5;
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
				// insert the reservation into the database using AddData
				AD.ReserveWorkplace("Test Subject", Int32.Parse(roomInfo.Item1), roomInfo.Item4, roomInfo.Item5);
				DialogResult result = MessageBox.Show("Reservation Completed", "Dialog Title", MessageBoxButtons.OK);
				if (result == DialogResult.OK)
				{
					Environment.Exit(0);
				}
			};

				this.Controls.Add(ReserveButton);

			
		}

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReserveWorkplace_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
