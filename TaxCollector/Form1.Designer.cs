namespace TaxCollector
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTaxableIncome = new System.Windows.Forms.Label();
            this.lblIncomeTaxOwed = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.txtIncomeTaxOwed = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNameOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(46, 138);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // lblTaxableIncome
            // 
            this.lblTaxableIncome.AutoSize = true;
            this.lblTaxableIncome.Enabled = false;
            this.lblTaxableIncome.Location = new System.Drawing.Point(13, 68);
            this.lblTaxableIncome.Name = "lblTaxableIncome";
            this.lblTaxableIncome.Size = new System.Drawing.Size(86, 13);
            this.lblTaxableIncome.TabIndex = 1;
            this.lblTaxableIncome.Text = "Taxable Income:";
            // 
            // lblIncomeTaxOwed
            // 
            this.lblIncomeTaxOwed.AutoSize = true;
            this.lblIncomeTaxOwed.Enabled = false;
            this.lblIncomeTaxOwed.Location = new System.Drawing.Point(12, 101);
            this.lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            this.lblIncomeTaxOwed.Size = new System.Drawing.Size(97, 13);
            this.lblIncomeTaxOwed.TabIndex = 2;
            this.lblIncomeTaxOwed.Text = "Income Tax Owed:";
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Enabled = false;
            this.txtTaxableIncome.Location = new System.Drawing.Point(139, 68);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(100, 20);
            this.txtTaxableIncome.TabIndex = 3;
            // 
            // txtIncomeTaxOwed
            // 
            this.txtIncomeTaxOwed.Enabled = false;
            this.txtIncomeTaxOwed.Location = new System.Drawing.Point(139, 98);
            this.txtIncomeTaxOwed.Name = "txtIncomeTaxOwed";
            this.txtIncomeTaxOwed.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeTaxOwed.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(162, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EscPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Enter name:\r\n";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // btnNameOK
            // 
            this.btnNameOK.Location = new System.Drawing.Point(208, 8);
            this.btnNameOK.Name = "btnNameOK";
            this.btnNameOK.Size = new System.Drawing.Size(75, 23);
            this.btnNameOK.TabIndex = 8;
            this.btnNameOK.Text = "OK";
            this.btnNameOK.UseVisualStyleBackColor = true;
            this.btnNameOK.Click += new System.EventHandler(this.btnNameOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 178);
            this.Controls.Add(this.btnNameOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtIncomeTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.lblIncomeTaxOwed);
            this.Controls.Add(this.lblTaxableIncome);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTaxableIncome;
        private System.Windows.Forms.Label lblIncomeTaxOwed;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.TextBox txtIncomeTaxOwed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNameOK;
    }
}

