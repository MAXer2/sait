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
    public partial class earn : Form
    {
      
        public earn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = label2.Text;
        int i = Convert.ToInt32(m);
            int k = i + 1;
            label2.Text = k.ToString();
        }

        private void button2_Click(object sender, EventArgs e, int i)
        {
           
            if (i >= 500) {
                i = i - 500;
                int k = i + 2;

            }

        }

        private void Earn_Load(object sender, EventArgs e)
        {

        }
    }
}
