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
    public partial class KorzinaControl : UserControl
    {

        
       public string PriceTovara;
        public string id;
        public KorzinaControl(string _id, int value)
        {
            InitializeComponent();
             id = _id;
            List<string> infaOTovare = Form1.Select("SELECT Title, Price FROM `Products`" +
           " WHERE id = '" + id + "'");

            TovarName.Text = infaOTovare[0].ToString();
            PriceLabel.Text = infaOTovare[1].ToString();
            PriceTovara = infaOTovare[1].ToString();
            AmountLabel.Text = value.ToString() + " шт";
            //1
        }

        private void label13_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(AmountLabel.Text.Replace("шт", ""));
            AmountLabel.Text = (value + 1).ToString() + " шт";
            value = value + 1;
            PriceLabel.Text = (Convert.ToInt32(PriceTovara) * value).ToString();
            korzina.games[id] = value;
            korzina.TotalCount += 1;
            korzina.TotalPrice += Convert.ToInt32(PriceTovara);
        }


     

        private void label17_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(AmountLabel.Text.Replace("шт", ""));
            AmountLabel.Text = (value - 1).ToString() + " шт";
            value = value - 1;
            PriceLabel.Text = (Convert.ToInt32(PriceTovara) * value).ToString();
            korzina.games[id] = value;
            korzina.TotalCount -= 1;
            korzina.TotalPrice -= Convert.ToInt32(PriceTovara);
            korzina.games[id] = value;
            if (value == 0)
            {
                korzina.games.Remove(id);
            }
        }
    }
}
