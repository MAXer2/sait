﻿namespace Сайтец
{
    partial class KorzinaControl
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
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TovarName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.LightGray;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(344, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(409, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "+";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(40, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.ForeColor = System.Drawing.Color.DimGray;
            this.AmountLabel.Location = new System.Drawing.Point(361, 9);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(49, 24);
            this.AmountLabel.TabIndex = 26;
            this.AmountLabel.Text = "1 шт";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.PriceLabel.Location = new System.Drawing.Point(580, 10);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 24);
            this.PriceLabel.TabIndex = 25;
            this.PriceLabel.Text = "100 р";
            // 
            // TovarName
            // 
            this.TovarName.AutoSize = true;
            this.TovarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TovarName.ForeColor = System.Drawing.Color.DimGray;
            this.TovarName.Location = new System.Drawing.Point(55, 6);
            this.TovarName.Name = "TovarName";
            this.TovarName.Size = new System.Drawing.Size(211, 29);
            this.TovarName.TabIndex = 24;
            this.TovarName.Text = "Название товара";
            this.TovarName.Click += new System.EventHandler(this.TovarName_Click);
            // 
            // KorzinaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TovarName);
            this.Name = "KorzinaControl";
            this.Size = new System.Drawing.Size(680, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label TovarName;
    }
}
