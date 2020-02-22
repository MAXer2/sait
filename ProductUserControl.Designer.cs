namespace Сайтец
{
    partial class ProductUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUserControl));
            this.bunifuCards1 = new ns1.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.bunifuCards1.Controls.Add(this.nameTextBox);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 119);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(282, 62);
            this.bunifuCards1.TabIndex = 4;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("T-FLEX Type T", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(202, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "1000 Р";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("T-FLEX Type T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(200, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "400 Р";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 118);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("T-FLEX Type T", 15.75F);
            this.nameTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTextBox.Location = new System.Drawing.Point(5, 8);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(189, 50);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Text = "Assassin\'s creed: revival";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.Label2_TextChanged);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(282, 181);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}
