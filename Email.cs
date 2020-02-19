using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Сайтец
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        public static void SendMail()
        {
            MailAddress fromMailAddress = new MailAddress("madkeyspro@gmail.com", "Mad Key");
            MailAddress toAddress = new MailAddress("xmaxer2@yandex.ru", "Uncle Bob");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "My Subject";
                mailMessage.Body = "Text in the body";

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "maxer2005");

                smtpClient.Send(mailMessage);
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {
            SendMail();
        }
    }
}
