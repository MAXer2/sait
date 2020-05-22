using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Сайтец
{
    public partial class korzina : Form
    {
        /// <summary>
        /// Reленные товары
        /// </summary>
       // public static List<string> KuplennyeTovary = new List<string>();
        public static Dictionary<string, int> games = new Dictionary<string, int>();
        /// <summary>
        /// Общая стоимость
        /// </summary>
        public static int TotalPrice = 0;

        /// <summary>
        /// Общее кол-во
        /// </summary>
        public static int TotalCount = 0;

        public korzina()
        {
            InitializeComponent();
        }
        /// <summary>
        /// получение цены
        /// </summary>
        public static int GetPrice(string id)
            {

            List<string> infaOTovare = Form1.Select("SELECT Price FROM `Products`" +
           " WHERE id = '" + id + "'");
            return Convert.ToInt32(infaOTovare[0]);
        }

        /// <summary>
        /// стоимость товаров в корзине
        /// </summary>
        public static void calulateKorzina()
        {
            TotalCount = 0;
            TotalPrice = 0;
            foreach (KeyValuePair <string, int> MyGame in korzina.games)
            {
                TotalCount = TotalCount + MyGame.Value;
                TotalPrice = TotalPrice + MyGame.Value * GetPrice(MyGame.Key);
            }



        }
        private void korzina_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
           // foreach (string id in korzina.KuplennyeTovary)
           foreach (KeyValuePair <string,int> MyGame in korzina.games )
            {
               string id = MyGame.Key;
               
                KorzinaControl Korzina = new KorzinaControl(id, MyGame.Value);
                Korzina.Location = new Point(x, y);
                Korzina.Size = new Size(680, 42);
                //korzina.TotalPri

                panel3.Controls.Add(Korzina);
                y = y + 50;
            }

            SummaLabel.Text = korzina.TotalPrice.ToString() + " р";
        }
        public static void calculateKorzina ()
        {
            foreach (KeyValuePair <string, int> MyGame in korzina.games)
            {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            calculateKorzina();
            SummaLabel.Text = korzina.TotalPrice.ToString() + " Р";
            korzina_Load(sender, e);
        }
    }
}
