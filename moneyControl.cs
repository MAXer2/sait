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
    public partial class moneyControl : UserControl
    {
       // string ident;
        public moneyControl()
        {
            InitializeComponent();
        }

        private void moneyControl_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       /* public void infa(object sender, EventArgs e, string id)
        {
            ident = id;
            List<string> Profile = Form1.Select("SELECT Name, money FROM `Pokupately`" +
           " WHERE id = '" + id + "'");
            NameLabel.Text = Profile[0].ToString();
            moneylabel.Text = Profile[1].ToString();
            InitializeComponent();
        }*/
    }
}
