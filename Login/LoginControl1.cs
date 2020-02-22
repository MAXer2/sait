using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сайтец
{
    public partial class LoginControl1 : UserControl
    {
        public LoginControl1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.ShowDialog();

            if (Form1.successLogin)
            {
                Visible = false;
                Form1.money.Visible = true;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SignInForm f = new SignInForm();
            f.ShowDialog();
        }

        private void LoginControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
