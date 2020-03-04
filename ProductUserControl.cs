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
    public partial class ProductUserControl : UserControl
    {
        string id;

        public ProductUserControl(string _id)
        {
            InitializeComponent();
            id = _id;
            // pictureBox1.Load("https://steammachine.ru/slider/2337648-220x126.jpg");


            List<string> infaOTovare = Form1.Select("SELECT Title, Price, Image FROM `Products`" +
                " WHERE id = '" + id + "'");
            nameTextBox.Text = infaOTovare[0].ToString();
            label1.Text = infaOTovare[1].ToString() + " Р";

            if (nameTextBox.Text.Length < 12)
            {
                nameTextBox.Font = new Font("T-FLEX Type T", 20F);
            }

            try
            {
                pictureBox1.Load(infaOTovare[2].ToString());
            }
            catch (Exception) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tovar t1 = new tovar(id);
            t1.ShowDialog();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
