namespace TestRate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.txtBt = new System.Windows.Forms.TextBox();
            this.txtBV = new System.Windows.Forms.TextBox();
            this.lblS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ежемесячная процентная ставка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество месяцев";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Объём кредита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма для погашения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(278, 28);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(136, 22);
            this.txtBx.TabIndex = 5;
            // 
            // txtBt
            // 
            this.txtBt.Location = new System.Drawing.Point(278, 64);
            this.txtBt.Name = "txtBt";
            this.txtBt.Size = new System.Drawing.Size(136, 22);
            this.txtBt.TabIndex = 6;
            // 
            // txtBV
            // 
            this.txtBV.Location = new System.Drawing.Point(278, 105);
            this.txtBV.Name = "txtBV";
            this.txtBV.Size = new System.Drawing.Size(136, 22);
            this.txtBV.TabIndex = 7;
            // 
            // lblS
            // 
            this.lblS.Location = new System.Drawing.Point(278, 197);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(136, 22);
            this.lblS.TabIndex = 8;
            this.lblS.TextChanged += new System.EventHandler(this.lblS_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 330);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.txtBV);
            this.Controls.Add(this.txtBt);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Процентная ставка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.TextBox txtBt;
        private System.Windows.Forms.TextBox txtBV;
        private System.Windows.Forms.TextBox lblS;
    }
}

