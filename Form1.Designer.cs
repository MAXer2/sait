namespace Сайтец
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bannerPictureBox = new System.Windows.Forms.PictureBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(551, 380);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(142, 141);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(371, 380);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(142, 141);
            this.panel7.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(195, 380);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(142, 141);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(21, 380);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(142, 141);
            this.panel9.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(606, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "пользователь";
            // 
            // bannerPictureBox
            // 
            this.bannerPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bannerPictureBox.Image = global::Сайтец.Properties.Resources.banner1;
            this.bannerPictureBox.Location = new System.Drawing.Point(38, 14);
            this.bannerPictureBox.Name = "bannerPictureBox";
            this.bannerPictureBox.Size = new System.Drawing.Size(361, 155);
            this.bannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerPictureBox.TabIndex = 0;
            this.bannerPictureBox.TabStop = false;
            this.bannerPictureBox.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(606, 112);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(139, 20);
            this.textBox14.TabIndex = 10;
            this.textBox14.Text = "логин";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(606, 149);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(139, 20);
            this.textBox15.TabIndex = 11;
            this.textBox15.Text = "пароль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(748, 576);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.bannerPictureBox);
            this.Name = "Form1";
            this.Text = "глав форм";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bannerPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
    }
}

