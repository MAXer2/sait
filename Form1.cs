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
        public static int maxPrice;
        public static int minnPrice;
        public static bool successLogin = false;
     
        public static int admin = 0;
        public static moneyControl money = new moneyControl();
        public static LoginControl1 login = new LoginControl1();


        List<Image> banners = new List<Image>();
        int bannerIndex = 0;
        public Form1()
        {
            InitializeComponent();
            showFilterPanel(null, null);
            login.Location = new Point(422,11);
            panel1.Controls.Add(login);
            money.Visible = false;
            money.Location = new Point(500, 14);
            panel1.Controls.Add(money);
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
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

            AdminButton.Visible = (admin == 1);
            label7.Text = korzina.TotalPrice.ToString() + " р";
            label5.Text = korzina.TotalCount.ToString() + " шт";
        }
        

        
        public static string CONNECTION_STRING =
            "SslMode=none;" +
            "Server=db4free.net;" +
            "database=ingenerka;" +
            "port=3306;" +
            "uid=ingenerka;" +
            "pwd=Beavis1989;" +
            "old guids=true;";/*
        "SslMode=none;" +
            "Server=localhost;" +
            "database=ingenerka;" +
            "port=3306;" +
            "uid=root;" +
            "old guids=true;";*/

        public static MySqlConnection CONN;

        /// <summary>
        /// Update-запрос
        /// </summary>
        public static void Update(string zapros)
        {
            MySqlCommand q = new MySqlCommand(zapros, CONN);
            MySqlDataReader r = q.ExecuteReader();
            r.Close();
        }

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

        void connect()
        {
            while (CONN.State != ConnectionState.Open)
            {
                try
                {
                    CONN.Open();
                }
                catch (Exception)
                {
                    connect();
                }
            }
        }


        public void Filterrr()
        { 
            String zapros = "SELECT id FROM Products WHERE 1=1";
            if (minprice.Text != "")
                zapros += " AND price >= " + Convert.ToInt32(minprice.Text);
            if (maxpricebutton.Text != "")
                zapros += " AND price <=" + Convert.ToInt32(maxpricebutton.Text);

            if (textBox1.Text != "")
                zapros += " AND upper(Title) like upper ('"+ textBox1.Text + "%')";

            List<string> products = Select(zapros);
            panel3.Controls.Clear();

            int x = 10;
            int y = 20;
            for (int i = 0; i < products.Count; i = i + 1)
            {
                ProductUserControl product = new ProductUserControl(products[i]);
                product.Location = new Point(x, y);
                product.Size = new Size(280, 190);

                //if (KuplennyeTovary.Contains(products[i]))
                {
                    panel3.Controls.Add(product);
                    x = x + 290;

                    if (x > this.Width - 450)
                    {
                        y = y + 200;
                        x = 10;
                    }
                }
            }

            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            label1.ForeColor = Color.FromArgb(93, 110, 134);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CONN = new MySqlConnection(CONNECTION_STRING);
            connect();
            Filterrr();
        }


        private Point MouseHook;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Cursor = Cursors.Default;
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            else
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
                Cursor = Cursors.Hand;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Visible= true;
            panel4.Visible = false;
            label6.ForeColor = Color.FromArgb(73, 90, 114);
            label2.ForeColor = Color.FromArgb(73, 90, 114);
            label3.ForeColor = Color.FromArgb(73, 90, 114);
            label1.ForeColor = Color.FromArgb(93, 110, 134);
        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SignInForm f = new SignInForm();
            f.ShowDialog();
        }


        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.ShowDialog();
        }


        private void earn_Click(object sender, EventArgs e)
        {
            earn e1 = new earn ();
            e1.ShowDialog ();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            korzina k1 = new korzina();
            k1.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(73, 90, 114);
            label3.ForeColor = Color.FromArgb(73, 90, 114);
            label1.ForeColor = Color.FromArgb(73, 90, 114);
            label2.ForeColor = Color.FromArgb(93, 110, 134);
            panel5.Visible = false;
            panel3.Visible = false;
            panel4.Visible =  true;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            UserControl2 loading = new UserControl2 ();
            loading.Location = new Point(233, 33);
            loading.Size = new Size(152, 21);
            Controls.Add(loading);
           
            label6.ForeColor = Color.FromArgb(73, 90, 114);
            label2.ForeColor = Color.FromArgb(73, 90, 114);
            label1.ForeColor = Color.FromArgb(73, 90, 114);
            label3.ForeColor = Color.FromArgb(93, 110, 134);
            panel5.Visible = true;
            panel4.Visible =false;
            panel3.Visible = false;
        }


        private void AdminButton_Click(object sender, EventArgs e)
        {
             ButtonDesign D = new ButtonDesign();
             D.Show();
        }


        private void Panel2_Click(object sender, EventArgs e)
        {
            Filterrr();
        }

        /// <summary>
        /// Покпазываем панель фильтра
        /// </summary>
        private void showFilterPanel(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.ColumnStyles[1].Width != 0)
                tableLayoutPanel1.ColumnStyles[1].Width = 0;
            else
                tableLayoutPanel1.ColumnStyles[1].Width = 35;
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            Filterrr();
        }

        private void BunifuTrackbar2_ValueChanged(object sender, EventArgs e)
        {
            maxpricebutton.Text = bunifuTrackbar2.Value.ToString();
            maxPrice = Convert.ToInt32(maxpricebutton.Text);
        }

        private void BunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            minprice.Text = bunifuTrackbar1.Value.ToString();
            minnPrice = Convert.ToInt32(minprice.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
