﻿namespace Сайтец
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminButton = new ns1.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuTextbox1 = new ns1.BunifuTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Location = new System.Drawing.Point(-1, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 64);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // AdminButton
            // 
            this.AdminButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.AdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminButton.BorderRadius = 0;
            this.AdminButton.ButtonText = "ВОЙТИ В АДМИНКУ";
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.AdminButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AdminButton.Iconimage = null;
            this.AdminButton.Iconimage_right = null;
            this.AdminButton.Iconimage_right_Selected = null;
            this.AdminButton.Iconimage_Selected = null;
            this.AdminButton.IconMarginLeft = 0;
            this.AdminButton.IconMarginRight = 0;
            this.AdminButton.IconRightVisible = true;
            this.AdminButton.IconRightZoom = 0D;
            this.AdminButton.IconVisible = true;
            this.AdminButton.IconZoom = 90D;
            this.AdminButton.IsTab = false;
            this.AdminButton.Location = new System.Drawing.Point(345, 14);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.AdminButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.AdminButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AdminButton.selected = false;
            this.AdminButton.Size = new System.Drawing.Size(160, 46);
            this.AdminButton.TabIndex = 20;
            this.AdminButton.Text = "ВОЙТИ В АДМИНКУ";
            this.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminButton.Textcolor = System.Drawing.Color.White;
            this.AdminButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(693, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = " 0 рублей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(696, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "0 товаров";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(772, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 46);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuTextbox1.Location = new System.Drawing.Point(18, 13);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(265, 49);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Поиск";
            this.bunifuTextbox1.Visible = false;
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.bunifuTextbox1.Click += new System.EventHandler(this.BunifuTextbox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(605, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 175);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.Panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(524, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главная";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(614, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "О нас";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(359, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скидки";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(544, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Испытай удачу";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(580, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Гарантии";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label9.Location = new System.Drawing.Point(228, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Рекомендуем";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(112, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Топ продаж";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label10.Location = new System.Drawing.Point(22, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Новинки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label11.Location = new System.Drawing.Point(436, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Предзаказ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label12.Location = new System.Drawing.Point(-4, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(863, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(-10, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 369);
            this.panel4.TabIndex = 24;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 199);
            this.panel3.TabIndex = 25;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.button1);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.panel5.Location = new System.Drawing.Point(0, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(822, 202);
            this.panel5.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(369, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 124);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(262, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 124);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(343, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 55);
            this.label13.TabIndex = 0;
            this.label13.Text = "СКОРО";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(475, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 124);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Макс. цена";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Фильтр";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(693, 56);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(116, 39);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 473);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "глав форм";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private ns1.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label5;
        public ns1.BunifuFlatButton AdminButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
    }
}

