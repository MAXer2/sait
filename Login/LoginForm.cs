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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginTextBox.Text == "Логин")
            { 
            loginTextBox.Clear();
            }
        }

        private Point MouseHook;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {            
            List<string> res = Form1.Select("SELECT status FROM `Pokupately`" +
                " WHERE Login = '" + loginTextBox.Text + "' && Pass = '" + passTextBox.Text + "'");
         
            if (res.Count > 0)
            {
                MessageBox.Show("Успешно");
                Form1.successLogin = true;
                Form1.money.Visible = true;
                Form1.login.Visible = false;
                if (res[0].ToString() == "admin")
                {
                    Form1.admin = 1;
                }
                Close();
            }
            else
            {
                res = Form1.Select("SELECT status FROM `Pokupately`" +
                    " WHERE Login = '" + loginTextBox.Text + "'");

                if (res.Count > 0)
                {
                    MessageBox.Show("Неправильный пароль");
                }
                else
                {
                    MessageBox.Show("Нет вас");
                }

                Form1.money.Visible = false;
                Form1.login.Visible = true;
              
            }

           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuFlatButton1_Click(sender, null);
            }
        }
    }
}
