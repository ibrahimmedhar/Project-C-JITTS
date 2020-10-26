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
        }

        //public static string server = "smtp.gmail.com";
        public static void SetMail()
        {
            string email = GetData.LoginInfo.UserID.ToString() ;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("projectcgroep1@gmail.com");
            mail.To.Add(GetData.LoginInfo.UserID);
            mail.Subject = "Confirmation of reservation";
            mail.Body = "Dear " + email +  ", your reservation is complete";
           
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("projectcgroep1@gmail.com", "projectc123");
            SmtpServer.EnableSsl = true; 
            SmtpServer.Send(mail);
        }
    }
}