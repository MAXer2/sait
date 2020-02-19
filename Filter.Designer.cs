namespace Сайтец
{
    partial class Filter
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuTrackbar1 = new ns1.BunifuTrackbar();
            this.bunifuTrackbar2 = new ns1.BunifuTrackbar();
            this.bunifuColorTransition1 = new ns1.BunifuColorTransition(this.components);
            this.minprice = new ns1.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new ns1.BunifuCheckbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuTrackbar1
            // 
            this.bunifuTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTrackbar1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuTrackbar1.BorderRadius = 0;
            this.bunifuTrackbar1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(130)))), ((int)(((byte)(154)))));
            this.bunifuTrackbar1.Location = new System.Drawing.Point(6, 20);
            this.bunifuTrackbar1.MaximumValue = 100;
            this.bunifuTrackbar1.Name = "bunifuTrackbar1";
            this.bunifuTrackbar1.Size = new System.Drawing.Size(197, 30);
            this.bunifuTrackbar1.SliderRadius = 0;
            this.bunifuTrackbar1.TabIndex = 4;
            this.bunifuTrackbar1.Value = 0;
            this.bunifuTrackbar1.ValueChanged += new System.EventHandler(this.BunifuTrackbar1_ValueChanged);
            // 
            // bunifuTrackbar2
            // 
            this.bunifuTrackbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTrackbar2.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuTrackbar2.BorderRadius = 0;
            this.bunifuTrackbar2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(130)))), ((int)(((byte)(154)))));
            this.bunifuTrackbar2.Location = new System.Drawing.Point(6, 43);
            this.bunifuTrackbar2.MaximumValue = 100;
            this.bunifuTrackbar2.Name = "bunifuTrackbar2";
            this.bunifuTrackbar2.Size = new System.Drawing.Size(197, 30);
            this.bunifuTrackbar2.SliderRadius = 0;
            this.bunifuTrackbar2.TabIndex = 5;
            this.bunifuTrackbar2.Value = 99;
            this.bunifuTrackbar2.ValueChanged += new System.EventHandler(this.BunifuTrackbar2_ValueChanged);
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
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
            this.minprice.Location = new System.Drawing.Point(5, 78);
            this.minprice.Margin = new System.Windows.Forms.Padding(5);
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(90, 29);
            this.minprice.TabIndex = 7;
            this.minprice.Text = "Мин цена";
            this.minprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.minprice.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox1_OnValueChanged);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(109, 78);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(95, 30);
            this.bunifuMaterialTextbox2.TabIndex = 8;
            this.bunifuMaterialTextbox2.Text = "Макс цена";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox2.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox2_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(90, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(25, 122);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 10;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.BunifuCheckbox1_OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(46, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Только в наличии";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(32, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Товар по скидке";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(7, 187);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 12;
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.BunifuCheckbox2_OnChange);
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
            this.comboBox1.Location = new System.Drawing.Point(8, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.minprice);
            this.Controls.Add(this.bunifuTrackbar2);
            this.Controls.Add(this.bunifuTrackbar1);
            this.Controls.Add(this.label1);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(220, 345);
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuTrackbar bunifuTrackbar1;
        private ns1.BunifuTrackbar bunifuTrackbar2;
        private ns1.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuCheckbox bunifuCheckbox2;
        public System.Windows.Forms.ComboBox comboBox1;
        public ns1.BunifuMaterialTextbox minprice;
        public ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Button button1;
    }
}
