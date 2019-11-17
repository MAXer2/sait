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
    public partial class tovar : Form
    {
        public tovar(string id)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
        }

        private void tovar_Load(object sender, EventArgs e)
        {
            panel3.Location = new Point(Width / 10, Height / 10);
        }
    }
}
