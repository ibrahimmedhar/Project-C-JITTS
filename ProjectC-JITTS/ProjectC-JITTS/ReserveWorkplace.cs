using ProjectC_JITTS.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
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
		public ReserveWorkplace(int room_id, string date)
        {
            InitializeComponent();
			bool succesInsert;

			GetData GD = new GetData();
			AddData AD = new AddData();

			this.AutoScroll = true;
			Tuple<string, string, string, string, string, string> roomInfo = GD.ShowRoomByKeys(room_id, date);

			Label LB1 = new Label();
			LB1.Text = "Location: " + roomInfo.Item6 +
				"\n\nRoom no selected: " + roomInfo.Item1 + 
				"\n\nWorkplaces: " + roomInfo.Item2 + 
				"\n\nWorkplaces left:  " + roomInfo.Item3 + 
				"\n\nLocation Key:  " + roomInfo.Item4 +
				"\n\nDate Selected:	" + DateTime.Parse(roomInfo.Item5).ToString("dd-MM-yyyy");

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
				succesInsert = AD.ReserveWorkplace(GetData.LoginInfo.UserID, room_id, Int32.Parse(roomInfo.Item1), roomInfo.Item4, roomInfo.Item5);
				if (succesInsert)
                {
					DialogResult result = MessageBox.Show("Reservation Completed", "Dialog Title", MessageBoxButtons.OK);
					if (result == DialogResult.OK)
					{
						string email = GetData.LoginInfo.UserID.ToString();
						MailMessage mail = new MailMessage();
						SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
						mail.From = new MailAddress("projectcgroep1@gmail.com");
						mail.To.Add(GetData.LoginInfo.UserID);
						mail.Subject = "Confirmation of reservation";
						mail.Body = 
							"Your reservation has succesfully been completed: \n\n" +	
							"Location: " + roomInfo.Item6 +
							"\nRoom no selected: " + roomInfo.Item1 +
							"\nLocation Key:  " + roomInfo.Item4 +
							"\nDate Selected:	" + DateTime.Parse(roomInfo.Item5).ToString("dd-MM-yyyy"); ;

						SmtpServer.Port = 587;
						SmtpServer.Credentials = new System.Net.NetworkCredential("projectcgroep1@gmail.com", "projectc123");
						SmtpServer.EnableSsl = true;
						SmtpServer.Send(mail);
						
						this.Hide();
						this.Close();
					}
				}
				else
                {
					MessageBox.Show("Mislukt");
                }

			};

				this.Controls.Add(ReserveButton);

			
		}
		
    }
}