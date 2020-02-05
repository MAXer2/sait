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

namespace Сайтец
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
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
            }
            else
            {
                MessageBox.Show("У вас, сударь, пароль аляповат-с");
            }

            Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
             Close();
Close();

        }

       


        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (loginTextBox.Text == "Логин")
            {
                loginTextBox.Clear();
            }
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (maskedTextBox2.Text == "Email")
            {
                maskedTextBox2.Clear();
            }
        }

        private void maskedTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (maskedTextBox3.Text == "Телефон")
            {
                maskedTextBox3.Clear();
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

    }
}
