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

        public static void SendMail()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress fromm = new MailAddress("madkeypro@gmail.com", "MadKeys");
            MailAddress to = new MailAddress("xmaxer2@yandex.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(fromm, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("madkeypro@gmail.com", "maxer2005");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }

        private void Email_Load(object sender, EventArgs e)
        {
            SendMail();
        }
    }
}
