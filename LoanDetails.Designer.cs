namespace LoanRepaymentApp
{
    partial class LoanDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentNo = new System.Windows.Forms.TextBox();
            this.PaymentAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrincipalAmountPaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InterestAmountPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoanOutstandingBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = LocalResources.PaymentNoText;
            // 
            // PaymentNo
            // 
            this.PaymentNo.Enabled = false;
            this.PaymentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentNo.Location = new System.Drawing.Point(283, 36);
            this.PaymentNo.Name = "PaymentNo";
            this.PaymentNo.Size = new System.Drawing.Size(168, 26);
            this.PaymentNo.TabIndex = 1;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.Enabled = false;
            this.PaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PaymentAmount.Location = new System.Drawing.Point(283, 64);
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.Size = new System.Drawing.Size(168, 26);
            this.PaymentAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = LocalResources.PaymentAmountText;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = LocalResources.PrincipalAmountPaidText;
            // 
            // PrincipalAmountPaid
            // 
            this.PrincipalAmountPaid.Enabled = false;
            this.PrincipalAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrincipalAmountPaid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PrincipalAmountPaid.Location = new System.Drawing.Point(283, 93);
            this.PrincipalAmountPaid.Name = "PrincipalAmountPaid";
            this.PrincipalAmountPaid.Size = new System.Drawing.Size(168, 26);
            this.PrincipalAmountPaid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = LocalResources.LoanDetailsFormTitle;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InterestAmountPaid
            // 
            this.InterestAmountPaid.Enabled = false;
            this.InterestAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestAmountPaid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InterestAmountPaid.Location = new System.Drawing.Point(283, 121);
            this.InterestAmountPaid.Name = "InterestAmountPaid";
            this.InterestAmountPaid.Size = new System.Drawing.Size(168, 26);
            this.InterestAmountPaid.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = LocalResources.LoanOutstandingBalanceText;
            // 
            // LoanOutstandingBalance
            // 
            this.LoanOutstandingBalance.Enabled = false;
            this.LoanOutstandingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanOutstandingBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoanOutstandingBalance.Location = new System.Drawing.Point(283, 149);
            this.LoanOutstandingBalance.Name = "LoanOutstandingBalance";
            this.LoanOutstandingBalance.Size = new System.Drawing.Size(168, 26);
            this.LoanOutstandingBalance.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = LocalResources.InterestAmountPaidText;
            // 
            // LoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 208);
            this.Controls.Add(this.LoanOutstandingBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InterestAmountPaid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrincipalAmountPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaymentAmount);
            this.Controls.Add(this.PaymentNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoanDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = LocalResources.LoanDetailsFormText;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox PaymentNo;
        public System.Windows.Forms.TextBox PaymentAmount;
        public System.Windows.Forms.TextBox PrincipalAmountPaid;
        public System.Windows.Forms.TextBox InterestAmountPaid;
        public System.Windows.Forms.TextBox LoanOutstandingBalance;
        private System.Windows.Forms.Label label5;
    }
}