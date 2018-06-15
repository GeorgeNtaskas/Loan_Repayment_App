namespace LoanRepaymentApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoanMainDetailsBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.YearRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoanPeriodTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AnnualInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.LoanAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.LoanAmortizationScheduleBox = new System.Windows.Forms.GroupBox();
            this.ExportToPdf = new System.Windows.Forms.Button();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.ScheduleGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LoanAmountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AnnualInterestRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoanPeriodErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoanMainDetailsBox.SuspendLayout();
            this.LoanAmortizationScheduleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanAmountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualInterestRateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanPeriodErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoanMainDetailsBox
            // 
            this.LoanMainDetailsBox.Controls.Add(this.label17);
            this.LoanMainDetailsBox.Controls.Add(this.label16);
            this.LoanMainDetailsBox.Controls.Add(this.label15);
            this.LoanMainDetailsBox.Controls.Add(this.YearRadioButton);
            this.LoanMainDetailsBox.Controls.Add(this.MonthsRadioButton);
            this.LoanMainDetailsBox.Controls.Add(this.label14);
            this.LoanMainDetailsBox.Controls.Add(this.label13);
            this.LoanMainDetailsBox.Controls.Add(this.label12);
            this.LoanMainDetailsBox.Controls.Add(this.label11);
            this.LoanMainDetailsBox.Controls.Add(this.label10);
            this.LoanMainDetailsBox.Controls.Add(this.label9);
            this.LoanMainDetailsBox.Controls.Add(this.label8);
            this.LoanMainDetailsBox.Controls.Add(this.label7);
            this.LoanMainDetailsBox.Controls.Add(this.label6);
            this.LoanMainDetailsBox.Controls.Add(this.LoanPeriodTextBox);
            this.LoanMainDetailsBox.Controls.Add(this.label5);
            this.LoanMainDetailsBox.Controls.Add(this.AnnualInterestRateTextBox);
            this.LoanMainDetailsBox.Controls.Add(this.LoanAmountTextBox);
            this.LoanMainDetailsBox.Controls.Add(this.label4);
            this.LoanMainDetailsBox.Controls.Add(this.Calculate_Button);
            this.LoanMainDetailsBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanMainDetailsBox.Location = new System.Drawing.Point(15, 106);
            this.LoanMainDetailsBox.Name = "LoanMainDetailsBox";
            this.LoanMainDetailsBox.Size = new System.Drawing.Size(957, 225);
            this.LoanMainDetailsBox.TabIndex = 0;
            this.LoanMainDetailsBox.TabStop = false;
            this.LoanMainDetailsBox.Text = LocalResources.MainDetailsText;
            this.LoanMainDetailsBox.Paint += new System.Windows.Forms.PaintEventHandler(this.LoanMainDetailsBox_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(455, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 21);
            this.label17.TabIndex = 20;
            this.label17.Text = LocalResources.LoanPeriodEx;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(455, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = LocalResources.AnnualInterestRateEx;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(455, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 21);
            this.label15.TabIndex = 18;
            this.label15.Text = LocalResources.LoanAmountEx;
            // 
            // YearRadioButton
            // 
            this.YearRadioButton.AutoSize = true;
            this.YearRadioButton.Location = new System.Drawing.Point(220, 154);
            this.YearRadioButton.Name = "YearRadioButton";
            this.YearRadioButton.Size = new System.Drawing.Size(71, 25);
            this.YearRadioButton.TabIndex = 17;
            this.YearRadioButton.Text = LocalResources.YearsText;
            this.YearRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonthsRadioButton
            // 
            this.MonthsRadioButton.AutoSize = true;
            this.MonthsRadioButton.Checked = true;
            this.MonthsRadioButton.Location = new System.Drawing.Point(220, 127);
            this.MonthsRadioButton.Name = "MonthsRadioButton";
            this.MonthsRadioButton.Size = new System.Drawing.Size(86, 25);
            this.MonthsRadioButton.TabIndex = 16;
            this.MonthsRadioButton.TabStop = true;
            this.MonthsRadioButton.Text = LocalResources.MonthsText;
            this.MonthsRadioButton.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 21);
            this.label14.TabIndex = 15;
            this.label14.Text = LocalResources.LoanPeriodTypeText;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "(";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(392, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = ")";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(382, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(376, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = LocalResources.EssentialInfoText;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(200, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(200, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(200, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = LocalResources.LoanPeriodText;
            // 
            // LoanPeriodTextBox
            // 
            this.LoanPeriodTextBox.Location = new System.Drawing.Point(220, 96);
            this.LoanPeriodTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.LoanPeriodTextBox.Name = "LoanPeriodTextBox";
            this.LoanPeriodTextBox.Size = new System.Drawing.Size(220, 27);
            this.LoanPeriodTextBox.TabIndex = 5;
            this.LoanPeriodTextBox.TextChanged += new System.EventHandler(this.LoanPeriodTextBox_TextChanged);
            this.LoanPeriodTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LoanPeriodTextBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = LocalResources.AnnualInterestRateText;
            // 
            // AnnualInterestRateTextBox
            // 
            this.AnnualInterestRateTextBox.Location = new System.Drawing.Point(220, 67);
            this.AnnualInterestRateTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.AnnualInterestRateTextBox.Name = "AnnualInterestRateTextBox";
            this.AnnualInterestRateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnnualInterestRateTextBox.Size = new System.Drawing.Size(220, 27);
            this.AnnualInterestRateTextBox.TabIndex = 4;
            this.AnnualInterestRateTextBox.TextChanged += new System.EventHandler(this.AnnualInterestRateTextBox_TextChanged);
            this.AnnualInterestRateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AnnualInterestRateTextBox_Validating);
            // 
            // LoanAmountTextBox
            // 
            this.LoanAmountTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoanAmountTextBox.Location = new System.Drawing.Point(220, 39);
            this.LoanAmountTextBox.Name = "LoanAmountTextBox";
            this.LoanAmountTextBox.Size = new System.Drawing.Size(220, 27);
            this.LoanAmountTextBox.TabIndex = 3;
            this.LoanAmountTextBox.TextChanged += new System.EventHandler(this.LoanAmountTextBox_TextChanged);
            this.LoanAmountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LoanAmountTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = LocalResources.LoanAmountText;
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Enabled = false;
            this.Calculate_Button.Location = new System.Drawing.Point(821, 186);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(130, 33);
            this.Calculate_Button.TabIndex = 0;
            this.Calculate_Button.Text = LocalResources.CalculateButtonText;
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // LoanAmortizationScheduleBox
            // 
            this.LoanAmortizationScheduleBox.Controls.Add(this.ExportToPdf);
            this.LoanAmortizationScheduleBox.Controls.Add(this.ExportToExcel);
            this.LoanAmortizationScheduleBox.Controls.Add(this.ScheduleGridView);
            this.LoanAmortizationScheduleBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanAmortizationScheduleBox.Location = new System.Drawing.Point(15, 337);
            this.LoanAmortizationScheduleBox.Name = "LoanAmortizationScheduleBox";
            this.LoanAmortizationScheduleBox.Size = new System.Drawing.Size(957, 612);
            this.LoanAmortizationScheduleBox.TabIndex = 1;
            this.LoanAmortizationScheduleBox.TabStop = false;
            this.LoanAmortizationScheduleBox.Text = LocalResources.ScheduleText;
            this.LoanAmortizationScheduleBox.Paint += new System.Windows.Forms.PaintEventHandler(this.LoanAmortizationScheduleBox_Paint);
            // 
            // ExportToPdf
            // 
            this.ExportToPdf.Enabled = false;
            this.ExportToPdf.Location = new System.Drawing.Point(669, 573);
            this.ExportToPdf.Name = "ExportToPdf";
            this.ExportToPdf.Size = new System.Drawing.Size(138, 33);
            this.ExportToPdf.TabIndex = 23;
            this.ExportToPdf.Text = LocalResources.ExportToPdfText;
            this.ExportToPdf.UseVisualStyleBackColor = true;
            this.ExportToPdf.Click += new System.EventHandler(this.ExportToPdf_Click);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Enabled = false;
            this.ExportToExcel.Location = new System.Drawing.Point(813, 573);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(138, 33);
            this.ExportToExcel.TabIndex = 22;
            this.ExportToExcel.Text = LocalResources.ExportToExcelText;
            this.ExportToExcel.UseVisualStyleBackColor = true;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // ScheduleGridView
            // 
            this.ScheduleGridView.AllowUserToAddRows = false;
            this.ScheduleGridView.AllowUserToDeleteRows = false;
            this.ScheduleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScheduleGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ScheduleGridView.Location = new System.Drawing.Point(10, 37);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ScheduleGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ScheduleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScheduleGridView.Size = new System.Drawing.Size(941, 530);
            this.ScheduleGridView.TabIndex = 0;
            this.ScheduleGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleGridView_CellDoubleClick);
            this.ScheduleGridView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.ScheduleGridView_SortCompare);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = LocalResources.Step2Text;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 21);
            this.label3.TabIndex = 4;
            this.label3.Text =  LocalResources.Step1Text;
            // 
            // LoanAmountErrorProvider
            // 
            this.LoanAmountErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.LoanAmountErrorProvider.ContainerControl = this;
            this.LoanAmountErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("LoanAmountErrorProvider.Icon")));
            // 
            // AnnualInterestRateErrorProvider
            // 
            this.AnnualInterestRateErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AnnualInterestRateErrorProvider.ContainerControl = this;
            this.AnnualInterestRateErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("AnnualInterestRateErrorProvider.Icon")));
            // 
            // LoanPeriodErrorProvider
            // 
            this.LoanPeriodErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.LoanPeriodErrorProvider.ContainerControl = this;
            this.LoanPeriodErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("LoanPeriodErrorProvider.Icon")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = LocalResources.WelcomeText;
            // 
            // MainForm
            // 
            this.AcceptButton = this.Calculate_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoanAmortizationScheduleBox);
            this.Controls.Add(this.LoanMainDetailsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = LocalResources.AppText;
            this.LoanMainDetailsBox.ResumeLayout(false);
            this.LoanMainDetailsBox.PerformLayout();
            this.LoanAmortizationScheduleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanAmountErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualInterestRateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanPeriodErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LoanMainDetailsBox;
        private System.Windows.Forms.GroupBox LoanAmortizationScheduleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoanPeriodTextBox;
        private System.Windows.Forms.TextBox LoanAmountTextBox;
        private System.Windows.Forms.TextBox AnnualInterestRateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ScheduleGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider LoanAmountErrorProvider;
        private System.Windows.Forms.ErrorProvider AnnualInterestRateErrorProvider;
        private System.Windows.Forms.ErrorProvider LoanPeriodErrorProvider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton YearRadioButton;
        private System.Windows.Forms.RadioButton MonthsRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ExportToExcel;
        private System.Windows.Forms.Button ExportToPdf;
    }
}

