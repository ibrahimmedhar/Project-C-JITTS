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
            Application.Run(new Home());
            SetMailWeekly();
        }

        //public static string server = "smtp.gmail.com";
        public static void SetMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("projectcgroep1@gmail.com");
            mail.To.Add("svensayed@gmail.com");
            mail.Subject = "Confirmation of reservation";
            mail.Body = "Your reservation is complete";
           
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("projectcgroep1@gmail.com", "projectc123");
            SmtpServer.EnableSsl = true; 
            SmtpServer.Send(mail);
        }

        public static void SetMailWeeklyNotification()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("projectcgroep1@gmail.com");
            mail.To.Add("svensayed@gmail.com");
            mail.Subject = "There are new reservations available";
            mail.Body = "It is possible to reserve new reservations";
            
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("projectcgroep1@gmail.com", "projectc123");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

        public static void SetMailWeekly()
        {
            DateTime BaseDate = new DateTime(2020,10,12);
            DateTime CurrentDate = DateTime.Now.Date;
            DateTime NextDate = BaseDate.AddDays(7);
            string stringNextDate = Convert.ToString(NextDate.ToShortDateString());

            if (CurrentDate.Equals(NextDate))
            {
                Console.WriteLine("Weekly Notification has been send to the email");
                SetMailWeeklyNotification();
            }

            
            Console.WriteLine("Dit is de huidige datum " + CurrentDate);
            Console.WriteLine("Dit is de datum van volgende week " + stringNextDate);
            Console.WriteLine(BaseDate);



        
        }
    }
}