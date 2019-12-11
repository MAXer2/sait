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

        private void korzina_Load(object sender, EventArgs e)
        {

            InitializeComponent();

            int x = 19;
            int y = 16;
            foreach (string id in Form1.KuplennyeTovary)
            {
                KorzinaControl Korzina = new KorzinaControl(id);
                Korzina.Location = new Point(x, y);
                Korzina.Size = new Size(680, 42);

                panel3.Controls.Add(Korzina);
                y = y + 50;
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://auth.robokassa.ru/Merchant/Index.aspx?MerchantLogin=Maxerkeys&InvId=0&Culture=ru&Encoding=utf-8&OutSum=0,00&SignatureValue=97ff97d0a565d05cb507b1028086339e");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
