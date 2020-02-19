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
    public partial class Filter : UserControl
    {
        public static bool filter = false;
        public static int maxPrice;
        public static int minnPrice;
        public Filter()
        {
            InitializeComponent();
            //1
        }

        void filtering()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            minprice.Text = bunifuTrackbar1.Value.ToString();
            minnPrice = Convert.ToInt32(minprice.Text);
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuTrackbar2_ValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = bunifuTrackbar2.Value.ToString();
            maxPrice = Convert.ToInt32(bunifuMaterialTextbox2.Text);
        }

        private void BunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }


        private void Filter_Load(object sender, EventArgs e)
        {

        }

        private Point MouseHook;

        private void Button1_Click_1(object sender, EventArgs e)
        {
            filter = true;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCheckbox2_OnChange(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        /*private void Filter_MouseMove(object sender, MouseEventArgs e)
         {

             Cursor = Cursors.Default;
             if (e.Button != MouseButtons.Left) MouseHook = e.Location;
             else
             {
                 Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
                 Cursor = Cursors.Hand;
             }
         }*/
    }
}
