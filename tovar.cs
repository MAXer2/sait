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
    public partial class tovar : Form
    {
        string ident;
        int price;
        int leng;
        public tovar(string id)
        {
            InitializeComponent();

            label1.ReadOnly = (Form1.admin == 0);
            label1.Enabled = (Form1.admin == 1);
            bunifuTileButton3.Visible = (Form1.admin == 1);

            ident = id;
            List<string> infaOTovare = Form1.Select("SELECT Title, Price, Image FROM `Products`" +
                " WHERE id = '" + id + "'");

           
            labelTovar.Text = infaOTovare[0].ToString();
            leng = labelTovar.Text.Length;
            if (leng >= 17)
            {
                int sizefont = Convert.ToInt32(labelTovar.Font.Size);
                labelTovar.Font = new Font("Microsoft Sans Serif", sizefont - 7);
            } else if (leng >= 30)
            {

                int sizefont = Convert.ToInt32(labelTovar.Font.Size);
                labelTovar.Font = new Font("Microsoft Sans Serif", sizefont - 20);
            }
            price = Convert.ToInt32(infaOTovare[1].ToString());
            label1.Text = price + " Р";
            
            try
            {
                pictureBox1.Load(infaOTovare[2].ToString());
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            WebForm w = new WebForm();
            w.ShowDialog();
        }

        private void tovar_Load(object sender, EventArgs e)
        {
            //panel3.Location = new Point(Width / 10, Height / 10);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (!korzina.games.ContainsKey(ident))
            {
                korzina.games.Add(ident, 1);
            } else
            {
                korzina.games[ident] = korzina.games[ident] + 1;
            }

            korzina.TotalPrice = korzina.TotalPrice + price;

            korzina.TotalCount = korzina.TotalCount + 1;
            MessageBox.Show("Добавлено");

            /*for (int i = 0; i < Form1.KuplennyeTovary.Count; i++)
            {
                MessageBox.Show(Form1.KuplennyeTovary[i]);
            }*/

            /*foreach(string tovar in Form1.KuplennyeTovary)
            {
                MessageBox.Show(tovar);
            }*/
            
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Form1.Update("UPDATE `Products`" +
               " SET title = '" + labelTovar.Text + "'" +
               ", price = " + label1.Text.Replace("Р", "") +
               " WHERE id = '" + ident + "'");
      

        }
    }
}
