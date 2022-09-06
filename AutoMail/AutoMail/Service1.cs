using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AutoMail
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (timer == null)
            {
                timer = new Timer();
            }
            timer.Interval = 30000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            MailGonder();
            timer.Start();
        }

        protected override void OnStop()
        {
        }

        public bool MailGonder()
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.office365.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(userName: "wissen_deneme@hotmail.com", password: "Wissen123.");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(address: "wissen_deneme@hotmail.com");

            mailMessage.To.Add(addresses: "metehan.kurnaz@yahoo.com");
            mailMessage.Subject = "Windows Servis Testi";
            mailMessage.Body = $"{DateTime.Now.ToString(format: "F")} zamanında çalıştı";

            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
