namespace Invoice_Total
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.txtDiscPercent = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Subtotal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "&total";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(412, 236);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 26);
            this.txtT.TabIndex = 4;
            // 
            // textDiscount
            // 
            this.textDiscount.Location = new System.Drawing.Point(412, 191);
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.Size = new System.Drawing.Size(100, 26);
            this.textDiscount.TabIndex = 5;
            // 
            // txtDiscPercent
            // 
            this.txtDiscPercent.Location = new System.Drawing.Point(412, 140);
            this.txtDiscPercent.Name = "txtDiscPercent";
            this.txtDiscPercent.Size = new System.Drawing.Size(100, 26);
            this.txtDiscPercent.TabIndex = 6;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(412, 89);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubtotal.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "&calculate ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(546, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "e&xit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtDiscPercent);
            this.Controls.Add(this.textDiscount);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.TextBox txtDiscPercent;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

