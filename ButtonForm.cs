using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class ButtonForm : Form
    {
        public Button button;

        public ButtonForm(Button btn)
        {
            InitializeComponent();

            this.Text = btn.Text;
            button = btn;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button.ForeColor;
            colorDialog1.ShowDialog();
            button.ForeColor = colorDialog1.Color;
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = button.Font;
            fontDialog1.ShowDialog();
            button.Font = fontDialog1.Font;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button.BackColor;
            colorDialog1.ShowDialog();
            button.BackColor = colorDialog1.Color;
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    File.Copy(openFileDialog1.FileName, @"..\..\images\FON\" + Path.GetFileName(openFileDialog1.FileName));
                }
                catch (Exception) { }
            }
        }
    }
}
