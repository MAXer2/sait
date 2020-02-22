using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void ДизайнToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)(((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl);
            ButtonForm bf = new ButtonForm(btn);
            bf.ShowDialog();
            btn = bf.button;
        }
    }
}
