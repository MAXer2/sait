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

        string CONNECTION_STRING =
            "SslMode=none;" +
            "Server=db4free.net;" +
            "database=ingenerka;" +
            "port=3306;" +
            "uid=ingenerka;" +
            "pwd=Beavis1989;" +
            "old guids=true;";
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection CONN = new MySqlConnection(CONNECTION_STRING);
           
            CONN.Open();

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


            res = new List<string>();
            q = new MySqlCommand("SELECT * FROM Pokupately", CONN);
            r = q.ExecuteReader();

            while (r.Read())
            {
                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    res.Add(r[inc].ToString());
                }
            }
            r.Close();

            textBox4.Text = res[0];
            textBox14.Text = res[1];
            textBox15.Text = res[2];


        }
    }
}
