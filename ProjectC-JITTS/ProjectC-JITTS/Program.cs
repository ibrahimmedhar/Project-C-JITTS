using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectC_JITTS.Database;

namespace ProjectC_JITTS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            SetMailWeekly();
        }

        public static void SetMailWeekly()
        {
            //checks if the current day is monday
            DateTime CurrentDate = DateTime.Now.Date;
            if (CurrentDate.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Today is " + CurrentDate.DayOfWeek);

                //If the current date is monday -> SetMailWeeklyNotification()
                SetMailWeeklyNotification();
            }
            else
            {
                Console.WriteLine("Today is not monday, it is " + CurrentDate.DayOfWeek);
            }     
        }

        public static void SetMailWeeklyNotification()
        {
            string email = Convert.ToString(GetData.LoginInfo.UserID);
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("projectcgroep1@gmail.com");
            mail.To.Add(GetData.LoginInfo.UserID);
            mail.Subject = "There are new reservations available";
            mail.Body = "Dear " + email + " It is possible to reserve new reservations";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("projectcgroep1@gmail.com", "projectc123");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}
