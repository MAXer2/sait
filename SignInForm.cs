using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace Сайтец
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        public static void SendMail(string email, string name, string login)
        {
            MailAddress fromMailAddress = new MailAddress("madkeyspro@gmail.com", "Mad Key");
            MailAddress toAddress = new MailAddress(email, name);

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Вы успешно зарегестрированы";
                mailMessage.Body = "Привет," + name + "вы зарегестрировались" +
                    "в нашем онлайн магазине Mad Keys. Ваш логин -" + login 
                    + "Желаем вам приятнх покупок";

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "maxer2005");

                smtpClient.Send(mailMessage);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {                
            if (maskedTextBox5.Text == passTextBox.Text)
            {
                MySqlCommand q = new MySqlCommand(
                    "INSERT INTO Pokupately (Login, Name, Pass, Number, email) VALUES ('" + 
                        loginTextBox.Text + "', '" +
                        maskedTextBox1.Text + "', '" + 
                        passTextBox.Text + "', '" + 
                        maskedTextBox3.Text + "', '" +
                        maskedTextBox2.Text + "')" , Form1.CONN);
                MySqlDataReader r = q.ExecuteReader();
                r.Close();
                MessageBox.Show("Случилось");
               // Email.SendMail("smtp.gmail.com","nonanonim757@gmail.com","widzi2005",maskedTextBox2.Text,"Регистрация","Вы зарегестрировались");
            }
            else
            {
                MessageBox.Show("У вас, сударь, пароль аляповат-с");
            }
            string email = maskedTextBox2.Text.ToString();
            string name = maskedTextBox1.Text.ToString();
            string login = loginTextBox.Text.ToString();
            SendMail(email,  name,  login);

            Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
             Close();

        }

       


        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(maskedTextBox1) && maskedTextBox1.Text == "Имя , фамилия ")
            {
                maskedTextBox1.Clear();
            }
            if (sender.Equals(loginTextBox) && loginTextBox.Text == "Логин")
            {
                loginTextBox.Clear();
            }

             if (sender.Equals(maskedTextBox2) && maskedTextBox2.Text == "Email")
            {
                maskedTextBox2.Clear();
            }

            if (sender.Equals(maskedTextBox3) && maskedTextBox3.Text == "Телефон")
            {
                maskedTextBox3.Clear();
            }
            if (sender.Equals(passTextBox))
            {
                label3.Visible = false;
            } else if (sender.Equals(label3)){
                label3.Visible = false;
            }
            if (sender.Equals(maskedTextBox5))
            {
                label5.Visible = false;
            }
            else if (sender.Equals(label5)){
                label5.Visible = false;
            }

        }

     
        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void maskedTextBox5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void passTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1_MouseClick(sender, null);

        }

        private void MaskedTextBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
