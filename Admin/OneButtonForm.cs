using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сайтец.Admin
{
    public partial class OneButtonForm : Form
    {
        ns1.BunifuThinButton2 btn;
        public OneButtonForm(ns1.BunifuThinButton2 _btn)
        {
            btn = _btn;
            InitializeComponent();
        }

        private void OneButtonForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = btn.Font;
            fontDialog1.ShowDialog();
            btn.Font = fontDialog1.Font;

            Form1.Update("DELETE FROM UniqueDesign WHERE ObjectName = '" + btn.Name + "' AND Form = '" + btn.ParentForm.Name + "'");

            Form1.Update("INSERT INTO UniqueDesign(ObjectType, ObjectName, Form, Parameter, Value) VALUES(" +
                "'" + btn.GetType() + "', " +  //Тип
                "'" + btn.Name + "', " +  //Имя
                "'" + btn.ParentForm.Name + "', " +  //Имя формы
                "'FontName', '" +
                btn.Font.Name +
                "')");
            Form1.Update("INSERT INTO UniqueDesign(ObjectType, ObjectName, Form, Parameter, Value) VALUES(" +
                "'" + btn.GetType() + "', " +  //Тип
                "'" + btn.Name + "', " +  //Имя
                "'" + btn.ParentForm.Name + "', " +  //Имя формы
                "'FontSize', '" +
                btn.Font.Size.ToString() +
                "')");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                btn.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                openFileDialog1.ShowDialog();
                btn.Font = fontDialog1.Font;

                string fileName =
                    System.IO.Path.GetFileName(openFileDialog1.FileName);
                System.IO.File.Copy(openFileDialog1.FileName, fileName);

                Form1.Update("DELETE FROM UniqueDesign"
                    + " WHERE ObjectName = '" + btn.Name +
                    "' AND Form = '" + btn.ParentForm.Name +
                    "' AND Parameter = 'Image'");

                Form1.Update("INSERT INTO UniqueDesign(ObjectType, ObjectName, Form, Parameter, Value) VALUES(" +
                    "'" + btn.GetType() + "', " +  //Тип
                    "'" + btn.Name + "', " +  //Имя
                    "'" + btn.ParentForm.Name + "', " +  //Имя формы
                    "'Image', '" +
                    openFileDialog1.FileName +
                    "')"); ;

            }
        }
    }
}
