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
        public KorzinaControl(string id, int value)
        {
            InitializeComponent();

            List<string> infaOTovare = Form1.Select("SELECT Title, Price, Image FROM `Products`" +
           " WHERE id = '" + id + "'");

            TovarName.Text = infaOTovare[0].ToString();

            PriceLabel.Text = infaOTovare[1].ToString();
            PriceTovara = infaOTovare[1].ToString();
            AmountLabel.Text = value.ToString() + " шт";
            //1
        }

        private void label13_Click(object sender, EventArgs e)
        {
            /* int shtuk = Convert.ToInt32(AmountLabel.Text.Replace("шт", ""));
             AmountLabel.Text = (shtuk + 1).ToString() + " шт";
             shtuk = shtuk + 1;
             PriceLabel.Text  = ( Convert.ToInt32(PriceTovara) * shtuk).ToString(); */
            int value = Convert.ToInt32(AmountLabel.Text.Replace("шт", ""));
            AmountLabel.Text = (value + 1).ToString() + " шт";
            value = value + 1;
            PriceLabel.Text = (Convert.ToInt32(PriceTovara) * value).ToString();
        }


        private void label17_Click(object sender, EventArgs e, int value)
        {
           // int shtuk = Convert.ToInt32(AmountLabel.Text.Replace("шт", ""));
        //    AmountLabel.Text = korzina..Value.ToString() + " шт";
       
          //  shtuk = shtuk - 1;
            PriceLabel.Text = (Convert.ToInt32(PriceTovara) / value).ToString();

            PriceTovara = (Convert.ToInt32(PriceTovara) / value).ToString();
        }

    }
}
