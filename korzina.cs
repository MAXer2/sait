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

        private void korzina_Load(object sender, EventArgs e, string id)
        {

            InitializeComponent();
            List<string> infaOTovare = Form1.Select("SELECT Title, Price, Image FROM `Products`" +
           " WHERE id = '" + id + "'");
            label1.Text = infaOTovare[0].ToString();
            label2.Text = infaOTovare[1].ToString() + " Р";
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://auth.robokassa.ru/Merchant/Index.aspx?MerchantLogin=Maxerkeys&InvId=0&Culture=ru&Encoding=utf-8&OutSum=0,00&SignatureValue=97ff97d0a565d05cb507b1028086339e");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
