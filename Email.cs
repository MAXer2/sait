using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Сайтец
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        public static void SendMail(string smtpServer, string from, string password,
            string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
               // MailAddress fromAdress = new MailAddress
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {
           
        }
    }
}
