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

        public static string CONNECTION_STRING =
            /*"SslMode=none;" +
            "Server=db4free.net;" +
            "database=ingenerka;" +
            "port=3306;" +
            "uid=ingenerka;" +
            "pwd=Beavis1989;" +
            "old guids=true;";*/
            "SslMode=none;" +
            "Server=localhost;" +
            "database=ingenerka;" +
            "port=3306;" +
            "uid=root;" +
            "old guids=true;";

        public static MySqlConnection CONN;

        /// <summary>
        /// Select-запрос
        /// </summary>
        /// <param name="sqlzapros"></param>
        /// <returns></returns>
        public static List<string> Select(string sqlzapros)
        {
            List<string> res = new List<string>();
            MySqlCommand q = new MySqlCommand(sqlzapros, Form1.CONN);
            MySqlDataReader r = q.ExecuteReader();

            while (r.Read())
            {
                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    res.Add(r[inc].ToString());
                }
            }
            r.Close();

            return res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CONN = new MySqlConnection(CONNECTION_STRING);           
            while (CONN.State != ConnectionState.Open)
            { 
                CONN.Open();
            }

            ProductUserControl product2 = new ProductUserControl("1");
            product2.Location = new Point(0, 0);
            panel6.Controls.Add(product2);

            ProductUserControl product = new ProductUserControl("2");
            product.Location = new Point(0, 0);
            panel3.Controls.Add(product);
            /*
            List<string> res = new List<string>();
            MySqlCommand q = new MySqlCommand("SELECT * FROM Products", CONN);
            MySqlDataReader r = q.ExecuteReader();

            while (r.Read())
            {
                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    res.Add(r[inc].ToString());
                }
            }
            r.Close();



            ProductUserControl product1 = new ProductUserControl();
            product1.Location = new Point(21,210);
            product1.TitleLabel.Text = res[0];
            product1.PriceLabel.Text = res[1];
            Controls.Add(product1);

            ProductUserControl product2 = new ProductUserControl();
            product2.Location = new Point(240, 210);
            product2.TitleLabel.Text = res[4+0];
            product2.PriceLabel.Text = res[4 + 1];
            Controls.Add(product2);

            /*Form1 f = new Form1();
            f.ShowDialog();*/


            /*res = new List<string>();
            q = new MySqlCommand("SELECT * FROM Pokupately", CONN);
            r = q.ExecuteReader();

            while (r.Read())
            {
                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    res.Add(r[inc].ToString());
                }
            }
            r.Close();*/


        }

        private void bannerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SignInForm f = new SignInForm();
            f.ShowDialog();
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.ShowDialog();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            earn e1 = new earn ();
            e1.ShowDialog ();
        }
    }
}
