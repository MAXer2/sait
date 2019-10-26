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
    public partial class Form1 : Form
    {
        List<Image> banners = new List<Image>();
        int bannerIndex = 0;
        public Form1()
        {
            InitializeComponent();
            
            banners.Add(Properties.Resources.banner1);
            banners.Add(Properties.Resources.banner2);
            banners.Add(Properties.Resources.banner3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bannerPictureBox.Image = banners[bannerIndex];
            bannerIndex++;
            if (bannerIndex >= banners.Count)
            {
                bannerIndex = 0;
            }
                
        }

        private void апнрапрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
