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
            this.ModerButton = new ns1.BunifuFlatButton();
            this.button5 = new System.Windows.Forms.Button();
            this.AdminButton = new ns1.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поменятьДизайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new ns1.BunifuCheckbox();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.maxpricebutton = new ns1.BunifuMaterialTextbox();
            this.minprice = new ns1.BunifuMaterialTextbox();
            this.bunifuTrackbar2 = new ns1.BunifuTrackbar();
            this.bunifuTrackbar1 = new ns1.BunifuTrackbar();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuThinButton27 = new ns1.BunifuThinButton2();
            this.bunifuThinButton26 = new ns1.BunifuThinButton2();
            this.bunifuThinButton24 = new ns1.BunifuThinButton2();
            this.bunifuThinButton23 = new ns1.BunifuThinButton2();
            this.earnButton = new ns1.BunifuThinButton2();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.buttonContextMenuStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.ModerButton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-1, -14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 79);
            this.panel1.TabIndex = 12;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // ModerButton
            // 
            this.ModerButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.ModerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.ModerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModerButton.BorderRadius = 0;
            this.ModerButton.ButtonText = "Добавить товар";
            this.ModerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModerButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.ModerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ModerButton.Iconimage = null;
            this.ModerButton.Iconimage_right = null;
            this.ModerButton.Iconimage_right_Selected = null;
            this.ModerButton.Iconimage_Selected = null;
            this.ModerButton.IconMarginLeft = 0;
            this.ModerButton.IconMarginRight = 0;
            this.ModerButton.IconRightVisible = true;
            this.ModerButton.IconRightZoom = 0D;
            this.ModerButton.IconVisible = true;
            this.ModerButton.IconZoom = 90D;
            this.ModerButton.IsTab = false;
            this.ModerButton.Location = new System.Drawing.Point(102, 17);
            this.ModerButton.Margin = new System.Windows.Forms.Padding(5);
            this.ModerButton.Name = "ModerButton";
            this.ModerButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.ModerButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.ModerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ModerButton.selected = false;
            this.ModerButton.Size = new System.Drawing.Size(174, 57);
            this.ModerButton.TabIndex = 32;
            this.ModerButton.Text = "Добавить товар";
            this.ModerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModerButton.Textcolor = System.Drawing.Color.White;
            this.ModerButton.TextFont = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModerButton.Visible = false;
            this.ModerButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.DarkRed;
            this.button5.Location = new System.Drawing.Point(17, 28);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 27);
            this.button5.TabIndex = 31;
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.AdminButton.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.AdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminButton.BorderRadius = 0;
            this.AdminButton.ButtonText = "Админ-панель";
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
            this.AdminButton.Location = new System.Drawing.Point(302, 17);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(5);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.AdminButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.AdminButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AdminButton.selected = false;
            this.AdminButton.Size = new System.Drawing.Size(201, 57);
            this.AdminButton.TabIndex = 20;
            this.AdminButton.Text = "Админ-панель";
            this.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminButton.Textcolor = System.Drawing.Color.White;
            this.AdminButton.TextFont = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(982, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = " 0 рублей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(988, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "0 товаров";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.ContextMenuStrip = this.buttonContextMenuStrip;
            this.pictureBox3.Location = new System.Drawing.Point(1114, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 57);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buttonContextMenuStrip
            // 
            this.buttonContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.buttonContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поменятьДизайнToolStripMenuItem});
            this.buttonContextMenuStrip.Name = "buttonContextMenuStrip";
            this.buttonContextMenuStrip.Size = new System.Drawing.Size(203, 28);
            this.buttonContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.buttonContextMenuStrip_Opening);
            // 
            // поменятьДизайнToolStripMenuItem
            // 
            this.поменятьДизайнToolStripMenuItem.Name = "поменятьДизайнToolStripMenuItem";
            this.поменятьДизайнToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.поменятьДизайнToolStripMenuItem.Text = "Поменять дизайн";
            this.поменятьДизайнToolStripMenuItem.Click += new System.EventHandler(this.поменятьДизайнToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(341, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
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
            this.label2.Location = new System.Drawing.Point(459, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "О нас";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(543, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Гарантии";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(155, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 12);
            this.panel4.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 426);
            this.panel3.TabIndex = 25;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.06542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.93458F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 123);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.78394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.216067F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 444);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.bunifuCheckbox2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.bunifuCheckbox1);
            this.panel2.Controls.Add(this.maxpricebutton);
            this.panel2.Controls.Add(this.minprice);
            this.panel2.Controls.Add(this.bunifuTrackbar2);
            this.panel2.Controls.Add(this.bunifuTrackbar1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(849, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 426);
            this.panel2.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 299);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 42);
            this.button4.TabIndex = 26;
            this.button4.Text = "filter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Выберите категорию",
            "Инди",
            "RPG",
            "Шутер",
            "Симулятор",
            "Стратегия"});
            this.comboBox1.Location = new System.Drawing.Point(10, 224);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label12.Location = new System.Drawing.Point(36, 169);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 33);
            this.label12.TabIndex = 24;
            this.label12.Text = "Товар по скидке";
            this.label12.Click += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = false;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(12, 178);
            this.bunifuCheckbox2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 23;
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label14.Location = new System.Drawing.Point(36, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 33);
            this.label14.TabIndex = 22;
            this.label14.Text = "Только в наличии";
            this.label14.Click += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(12, 144);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 21;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // maxpricebutton
            // 
            this.maxpricebutton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxpricebutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxpricebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.maxpricebutton.HintForeColor = System.Drawing.Color.Empty;
            this.maxpricebutton.HintText = "";
            this.maxpricebutton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.maxpricebutton.isPassword = false;
            this.maxpricebutton.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.maxpricebutton.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.maxpricebutton.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.maxpricebutton.LineThickness = 4;
            this.maxpricebutton.Location = new System.Drawing.Point(144, 90);
            this.maxpricebutton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.maxpricebutton.Name = "maxpricebutton";
            this.maxpricebutton.Size = new System.Drawing.Size(127, 37);
            this.maxpricebutton.TabIndex = 19;
            this.maxpricebutton.Text = "9999";
            this.maxpricebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // minprice
            // 
            this.minprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minprice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.minprice.HintForeColor = System.Drawing.Color.Empty;
            this.minprice.HintText = "";
            this.minprice.ImeMode = System.Windows.Forms.ImeMode.On;
            this.minprice.isPassword = false;
            this.minprice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.minprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.minprice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.minprice.LineThickness = 4;
            this.minprice.Location = new System.Drawing.Point(5, 90);
            this.minprice.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(120, 36);
            this.minprice.TabIndex = 18;
            this.minprice.Text = "0";
            this.minprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTrackbar2
            // 
            this.bunifuTrackbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTrackbar2.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuTrackbar2.BorderRadius = 0;
            this.bunifuTrackbar2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(130)))), ((int)(((byte)(154)))));
            this.bunifuTrackbar2.Location = new System.Drawing.Point(7, 47);
            this.bunifuTrackbar2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuTrackbar2.MaximumValue = 9999;
            this.bunifuTrackbar2.Name = "bunifuTrackbar2";
            this.bunifuTrackbar2.Size = new System.Drawing.Size(263, 35);
            this.bunifuTrackbar2.SliderRadius = 0;
            this.bunifuTrackbar2.TabIndex = 17;
            this.bunifuTrackbar2.Value = 9996;
            this.bunifuTrackbar2.ValueChanged += new System.EventHandler(this.BunifuTrackbar2_ValueChanged);
            // 
            // bunifuTrackbar1
            // 
            this.bunifuTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTrackbar1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuTrackbar1.BorderRadius = 0;
            this.bunifuTrackbar1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(130)))), ((int)(((byte)(154)))));
            this.bunifuTrackbar1.Location = new System.Drawing.Point(7, 18);
            this.bunifuTrackbar1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuTrackbar1.MaximumValue = 9999;
            this.bunifuTrackbar1.Name = "bunifuTrackbar1";
            this.bunifuTrackbar1.Size = new System.Drawing.Size(263, 35);
            this.bunifuTrackbar1.SliderRadius = 0;
            this.bunifuTrackbar1.TabIndex = 16;
            this.bunifuTrackbar1.Value = 0;
            this.bunifuTrackbar1.ValueChanged += new System.EventHandler(this.BunifuTrackbar1_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label15.Location = new System.Drawing.Point(119, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 42);
            this.label15.TabIndex = 20;
            this.label15.Text = "-";
            // 
            // bunifuThinButton27
            // 
            this.bunifuThinButton27.ActiveBorderThickness = 1;
            this.bunifuThinButton27.ActiveCornerRadius = 20;
            this.bunifuThinButton27.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton27.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton27.BackgroundImage")));
            this.bunifuThinButton27.ButtonText = "Новинки";
            this.bunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton27.IdleBorderThickness = 1;
            this.bunifuThinButton27.IdleCornerRadius = 20;
            this.bunifuThinButton27.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton27.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton27.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton27.Location = new System.Drawing.Point(148, 75);
            this.bunifuThinButton27.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton27.Name = "bunifuThinButton27";
            this.bunifuThinButton27.Size = new System.Drawing.Size(108, 37);
            this.bunifuThinButton27.TabIndex = 33;
            this.bunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "Главная";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton26.Location = new System.Drawing.Point(35, 75);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(113, 37);
            this.bunifuThinButton26.TabIndex = 32;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Скидки";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.Location = new System.Drawing.Point(270, 68);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(107, 49);
            this.bunifuThinButton24.TabIndex = 30;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Предзаказ";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.Location = new System.Drawing.Point(391, 69);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(135, 49);
            this.bunifuThinButton23.TabIndex = 29;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // earnButton
            // 
            this.earnButton.ActiveBorderThickness = 1;
            this.earnButton.ActiveCornerRadius = 20;
            this.earnButton.ActiveFillColor = System.Drawing.Color.White;
            this.earnButton.ActiveForecolor = System.Drawing.Color.White;
            this.earnButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.earnButton.BackColor = System.Drawing.Color.White;
            this.earnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("earnButton.BackgroundImage")));
            this.earnButton.ButtonText = "Испытай удачу";
            this.earnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.earnButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.earnButton.IdleBorderThickness = 1;
            this.earnButton.IdleCornerRadius = 20;
            this.earnButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.earnButton.IdleForecolor = System.Drawing.Color.White;
            this.earnButton.IdleLineColor = System.Drawing.Color.White;
            this.earnButton.Location = new System.Drawing.Point(662, 69);
            this.earnButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.earnButton.Name = "earnButton";
            this.earnButton.Size = new System.Drawing.Size(180, 49);
            this.earnButton.TabIndex = 28;
            this.earnButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.earnButton.Click += new System.EventHandler(this.earn_Click);
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
            this.bunifuThinButton21.ContextMenuStrip = this.buttonContextMenuStrip;
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(865, 70);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(292, 48);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.showFilterPanel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 582);
            this.Controls.Add(this.bunifuThinButton27);
            this.Controls.Add(this.bunifuThinButton26);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.earnButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "глав форм";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.buttonContextMenuStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label5;
        public ns1.BunifuFlatButton AdminButton;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private ns1.BunifuCheckbox bunifuCheckbox2;
        private System.Windows.Forms.Label label14;
        private ns1.BunifuCheckbox bunifuCheckbox1;
        public ns1.BunifuMaterialTextbox maxpricebutton;
        public ns1.BunifuMaterialTextbox minprice;
        private ns1.BunifuTrackbar bunifuTrackbar2;
        private ns1.BunifuTrackbar bunifuTrackbar1;
        private System.Windows.Forms.Label label15;
        private ns1.BunifuThinButton2 earnButton;
        private ns1.BunifuThinButton2 bunifuThinButton23;
        private ns1.BunifuThinButton2 bunifuThinButton24;
        private ns1.BunifuThinButton2 bunifuThinButton26;
        private ns1.BunifuThinButton2 bunifuThinButton27;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip buttonContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem поменятьДизайнToolStripMenuItem;
        public ns1.BunifuFlatButton ModerButton;
    }
}

