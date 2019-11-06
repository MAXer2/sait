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
            if (maskedTextBox1.Text == "Логин")
            { 
            maskedTextBox1.Clear();
            }
        }


        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {

            label4.Visible = false;

        }

    }
}
