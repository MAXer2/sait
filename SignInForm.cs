using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
             Close();
Close();

        }

       


        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (maskedTextBox1.Text == "Логин")
            {
                maskedTextBox1.Clear();
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

    }
}
