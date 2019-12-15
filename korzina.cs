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
    public partial class korzina : Form
    {
        public korzina()
        {
            InitializeComponent();
        }

        public int summa = 0;

        private void korzina_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            foreach (string id in Form1.KuplennyeTovary)
            {
                KorzinaControl Korzina = new KorzinaControl(id);
                Korzina.Location = new Point(x, y);
                Korzina.Size = new Size(680, 42);
                summa = summa + Convert.ToInt32(Korzina.PriceLabel.Text.Replace("р", ""));

                panel3.Controls.Add(Korzina);
                y = y + 50;
            }

            SummaLabel.Text = summa.ToString() + " р";
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://auth.robokassa.ru/Merchant/Index.aspx?MerchantLogin=Maxerkeys&InvId=0&Culture=ru&Encoding=utf-8&OutSum=0,00&SignatureValue=97ff97d0a565d05cb507b1028086339e");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
