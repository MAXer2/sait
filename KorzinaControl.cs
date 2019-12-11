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
        public KorzinaControl(string id)
        {
            InitializeComponent();

            List<string> infaOTovare = Form1.Select("SELECT Title, Price, Image FROM `Products`" +
           " WHERE id = '" + id + "'");

            TovarName.Text = infaOTovare[0].ToString();

            //1
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TovarName_Click(object sender, EventArgs e)
        {

        }
    }
}
