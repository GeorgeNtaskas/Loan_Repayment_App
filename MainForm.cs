using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanRepaymentApp
{
    public partial class MainForm : Form
    {
        //Boolean values for the validation of the tree main inputs
        public Boolean LoanAmountTextBox_Validation = false;
        public Boolean AnnualInterestRateTextBox_Validation = false;
        public Boolean LoanPeriodTextBox_Validation = false;
        //Loan Amortization Schedule DataTable
        public DataTable LoanAmortizationSceduleDt = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            //Insert Custom Sort to the main Grid View
            ScheduleGridView.SortCompare += new DataGridViewSortCompareEventHandler(this.ScheduleGridView_SortCompare);

            //The following DataTable will contain the Loan Amortization Shedule
            //The main columns of Loan Amortization Shedule are set
            PopulateDataGridView();
        }

        //GridView Generation with main columns
        public void PopulateDataGridView()
        {
            ScheduleGridView.ColumnCount = 5;
            ScheduleGridView.Columns[0].Name = LocalResources.PaymentNoLabel;
            ScheduleGridView.Columns[1].Name = LocalResources.PaymentAmountLabel;
            ScheduleGridView.Columns[2].Name = LocalResources.PrincipalAmountPaidLabel;
            ScheduleGridView.Columns[3].Name = LocalResources.InterestAmountPaidLabel;
            ScheduleGridView.Columns[4].Name = LocalResources.LoanOutstandingBalanceLabel;

            ScheduleGridView.Columns[LocalResources.PaymentNoLabel].HeaderText = LocalResources.PaymentNoText;
            ScheduleGridView.Columns[LocalResources.PaymentAmountLabel].HeaderText = LocalResources.PaymentAmountText;
            ScheduleGridView.Columns[LocalResources.PrincipalAmountPaidLabel].HeaderText = LocalResources.PrincipalAmountPaidText;
            ScheduleGridView.Columns[LocalResources.InterestAmountPaidLabel].HeaderText = LocalResources.InterestAmountPaidText;
            ScheduleGridView.Columns[LocalResources.LoanOutstandingBalanceLabel].Name = LocalResources.LoanOutstandingBalanceText;

            ScheduleGridView.Columns[0].Width = 135;
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            //Refresh the Main GridView in case of existing Elements
            Utils.RefreshGrid(ScheduleGridView);

            //Initializationg of three main values of calculations
            //Three main values are: LoanAmount,Annual Interest  Rate and Loan Period
            decimal LoanAmountValue = decimal.Parse(LoanAmountTextBox.Text.Trim());
            //Annual Interest Rate Percent, divide by the constant number of months for one year
            //Round to three decimals

            decimal AnnualInterestRateValue = (decimal.Parse(AnnualInterestRateTextBox.Text.Trim()) / 100) / Constant.MonthsOhYear;
            int LoanPeriodValue = Int32.Parse(LoanPeriodTextBox.Text.Trim());

            //Transformation of years to months, in case of years radio button is checked
            if (YearRadioButton.Checked == true)
            {
                LoanPeriodValue = LoanPeriodValue * Constant.MonthsOhYear;
            }

            //Calculation of Loan Amortization Shedule

            //Run the main for loop based on the value of Loan Period
            //Inside the main for loop, the Loan Amortization Shedule will be generated
            //The Loan Amortization Shedule is based on the Equal Total Payments method

            for (int i = 1; i <= LoanPeriodValue; i++)
            {
                decimal PaymentGenerated = LoanFormulas.Payment(LoanAmountValue, AnnualInterestRateValue, LoanPeriodValue);
                decimal PrincipalAmountPaidGenerated = LoanFormulas.PrincipalAmount(i, PaymentGenerated, AnnualInterestRateValue, LoanPeriodValue);
                decimal InterestAmountPaidGenerated = LoanFormulas.InterestAmountPaid(PaymentGenerated, PrincipalAmountPaidGenerated);
                decimal LoanOutstandingBalanceGenerated = LoanFormulas.LoanOutstandingBalance(InterestAmountPaidGenerated, AnnualInterestRateValue, PrincipalAmountPaidGenerated);
                //Insert the Calculation to the Main GridView
                
                if(i == LoanPeriodValue)
                {
                    PaymentGenerated += LoanOutstandingBalanceGenerated;
                    LoanOutstandingBalanceGenerated = 0;
                }

                ScheduleGridView.Rows.Add(new string[] { i.ToString(), Utils.ChangeToPrice(PaymentGenerated, true), Utils.ChangeToPrice(PrincipalAmountPaidGenerated, true), Utils.ChangeToPrice(InterestAmountPaidGenerated, true), Utils.ChangeToPrice(LoanOutstandingBalanceGenerated, true) });
            }

            //Enable Export To Excel Button, thus the grid contains rows
            ExportToExcel.Enabled = true;
            //Enable Export To Pdf Button, thus the grid contains rows
            ExportToPdf.Enabled = true;
        }

        //LoanAmountTextBox Validation    
        private void LoanAmountTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp_TextBox = (TextBox)sender;
            Utils.CheckEmptyAndOnlydecimalNumbersWithPresicion(Temp_TextBox, Temp_TextBox.Text.Replace(Constant.comma_separator, ""), LoanAmountErrorProvider);
        }

        //AnnualInterestRateTextBox Validation
        private void AnnualInterestRateTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp_TextBox = (TextBox)sender;
            Utils.CheckEmptyAndOnlyNumbersFromZeroToHundred(Temp_TextBox, AnnualInterestRateErrorProvider);
        }

        //LoanPeriodTextBox Validation
        private void LoanPeriodTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp_TextBox = (TextBox)sender;
            Utils.CheckEmptyAndOnlyNumbers(Temp_TextBox, LoanPeriodErrorProvider);
        }

        //LoanAmountTextBox when text changes
        private void LoanAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox Temp_TextBox = (TextBox)sender;

            LoanAmountTextBox_Validation = Utils.CheckEmptyAndOnlydecimalNumbersWithPresicion(Temp_TextBox, Temp_TextBox.Text.Replace(Constant.comma_separator, ""), LoanAmountErrorProvider);

            //If input of Loan Amount Text Box is validated, then it can be formatted
            if (LoanAmountTextBox_Validation)
            {
                Temp_TextBox.Text = Utils.FormatInputToPrice(Temp_TextBox.Text);
                Temp_TextBox.Select(Temp_TextBox.Text.Length, 0);
            }

            CalculationButtonEnable();
        }

        //AnnualInterestRateTextBox when text changes
        private void AnnualInterestRateTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox Temp_TextBox = (TextBox)sender;
            AnnualInterestRateTextBox_Validation = Utils.CheckEmptyAndOnlyNumbersFromZeroToHundred(Temp_TextBox, AnnualInterestRateErrorProvider);
            CalculationButtonEnable();
        }

        //LoanPeriodTextBox when text changes
        private void LoanPeriodTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox Temp_TextBox = (TextBox)sender;
            LoanPeriodTextBox_Validation = Utils.CheckEmptyAndOnlyNumbers(Temp_TextBox, LoanPeriodErrorProvider);
            CalculationButtonEnable();
        }

        //Check if Execute Button can be used, based on the values of input text boxes
        public void CalculationButtonEnable()
        {
            if (LoanAmountTextBox_Validation == true && AnnualInterestRateTextBox_Validation == true && LoanPeriodTextBox_Validation == true)
            {
                Calculate_Button.Enabled = true;
            }
            else
            {
                Calculate_Button.Enabled = false;
            }
        }

        //Custom sorting for columns
        private void ScheduleGridView_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            try
            {
                //Check the index of column, thus the first one is type of integer
                if (e.Column.Index == 0)
                {
                    if (decimal.Parse(e.CellValue1.ToString()) > decimal.Parse(e.CellValue2.ToString()))
                    {
                        e.SortResult = 1;
                    }
                    else if (decimal.Parse(e.CellValue1.ToString()) < decimal.Parse(e.CellValue2.ToString()))
                    {
                        e.SortResult = -1;
                    }
                    else
                    {
                        e.SortResult = 0;
                    }
                    e.Handled = true;
                }
                //Check the index of column, thus all the columns are type of decimal, except the last one
                else
                {
                    string CellValue1 = Utils.ClearString(e.CellValue1.ToString());
                    string CellValue2 = Utils.ClearString(e.CellValue2.ToString());

                    if (decimal.Parse(CellValue1) > decimal.Parse(CellValue2))
                    {
                        e.SortResult = 1;
                    }
                    else if (decimal.Parse(CellValue1) < decimal.Parse(CellValue2))
                    {
                        e.SortResult = -1;
                    }
                    else
                    {
                        e.SortResult = 0;
                    }
                    e.Handled = true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(LocalResources.UnexpectedErrorText);
            }
        }

        //Change the border of Loan Main Details Box
        private void LoanMainDetailsBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Utils.DrawGroupBox(box, e.Graphics, Color.Black, Color.DarkRed);
        }

        //Change the border of Loan Amortization Schedule Box
        private void LoanAmortizationScheduleBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Utils.DrawGroupBox(box, e.Graphics, Color.Black, Color.DarkRed);
        }

        //Export to Excel Click
        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcel(ScheduleGridView);
        }

        //Export to Pdf Click
        private void ExportToPdf_Click(object sender, EventArgs e)
        {
            Utils.ExportToPdf(ScheduleGridView);
        }

        private void ScheduleGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoanDetails DetailsForm = new LoanDetails();

            DetailsForm.PaymentNo.Text = ScheduleGridView.CurrentRow.Cells[0].Value.ToString();
            DetailsForm.PaymentAmount.Text = ScheduleGridView.CurrentRow.Cells[1].Value.ToString();
            DetailsForm.PrincipalAmountPaid.Text = ScheduleGridView.CurrentRow.Cells[2].Value.ToString();
            DetailsForm.InterestAmountPaid.Text = ScheduleGridView.CurrentRow.Cells[3].Value.ToString();
            DetailsForm.LoanOutstandingBalance.Text = ScheduleGridView.CurrentRow.Cells[4].Value.ToString();

            DetailsForm.ShowDialog();
        }
    }
}
