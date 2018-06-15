using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace LoanRepaymentApp
{
    class Utils
    {
        //Change the string to Price form with comma separator for thousands and symbol of pound
        public static string ChangeToPrice(object value, bool currency)
        {
            string value_ch = String.Format(Constant.BasicStringFormat, value);
            string Transformed_Price;
            if (currency == true)
            {
                Transformed_Price = String.Format(Program.Culture, Program.SymbolPounds + "{0:n}", decimal.Parse(value_ch));
            }
            else
            {
                Transformed_Price = String.Format(Program.Culture, "{0:n}", decimal.Parse(value_ch));
            }

            return Transformed_Price;
        }

        //Clear and Refresh DataGridView
        public static void RefreshGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
        }

        //Check if a TextBox is empty or contains decimal with precision 2
        public static Boolean CheckEmptyAndOnlydecimalNumbersWithPresicion(TextBox Temp_TextBox, string Temp_Text, ErrorProvider Err_Provider)
        {
            bool TextBox_Validation = false;

            //Check if TextBox is empty
            if (string.IsNullOrEmpty(Temp_Text))
            {
                Err_Provider.SetError(Temp_TextBox, LocalResources.EmptyLoanAmount);
            }
            //Check if TextBox contains decimal with precision 2
            else if (!Regex.IsMatch(Temp_Text, @"^\d+(,\d{3})*(\.\d{1,2})?$"))
            {
                Err_Provider.SetError(Temp_TextBox, LocalResources.InvalidLoanAmount);
            }
            //Correct Text
            else
            {
                Err_Provider.SetError(Temp_TextBox, null);
                TextBox_Validation = true;
            }

            return TextBox_Validation;
        }

        //Check if a TextBox is empty or contains percent number
        public static Boolean CheckEmptyAndOnlyNumbersFromZeroToHundred(TextBox Temp_TextBox, ErrorProvider Err_Provider)
        {
            bool TextBox_Validation = false;

            //Check if TextBox is empty
            if (string.IsNullOrEmpty(Temp_TextBox.Text))
            {
                Err_Provider.SetError(Temp_TextBox, LocalResources.EmptyAnnualInterestRate);
            }
            //Check if TextBox contains only numbers from zero to one hundred
            else if (!Regex.IsMatch(Temp_TextBox.Text, @"^(100([\.][0]{1,})?$|[0-9]{1,2}([\.][0-9]{1,})?)$"))
            {
                Err_Provider.SetError(Temp_TextBox, LocalResources.InvalidAnnualInterestRate);
            }
            //Correct Text
            else
            {
                Err_Provider.SetError(Temp_TextBox, null);
                TextBox_Validation = true;
            }

            return TextBox_Validation;
        }

        //Check if a TextBox is empty or contains only numbers
        public static Boolean CheckEmptyAndOnlyNumbers(TextBox Temp_TextBox, ErrorProvider Err_Provider)
        {
            bool TextBox_Validation = false;

            //Check if TextBox is empty
            if (string.IsNullOrEmpty(Temp_TextBox.Text))
            {
                Err_Provider.SetError(Temp_TextBox, LocalResources.EmptyLoanPeriod);
            }
            //Check if TextBox contains only numbers
            else if (!Regex.IsMatch(Temp_TextBox.Text, @"^[0-9]+$"))
            {
                Err_Provider.SetError(Temp_TextBox, LocalResources.InvalidLoanPeriod);
            }
            //Correct Text
            else
            {
                Err_Provider.SetError(Temp_TextBox, null);
                TextBox_Validation = true;
            }

            return TextBox_Validation;
        }

        public static string FormatInputToPrice(string Input_Text)
        {
            //In case of precision, the part of precision is added to the the end of input
            string Precion_Part = "";
            //temporary text
            string Temp_Text = Input_Text;

            if (Input_Text.Contains("."))
            {
                Precion_Part = Input_Text.Substring(Input_Text.LastIndexOf('.'));
                Temp_Text = Temp_Text.Replace(Precion_Part, "");
            }

            //Input Format to Amount
            string value_ch = String.Format(Constant.BasicStringFormat, Temp_Text);
            return String.Format(Program.Culture, "{0:N0}", decimal.Parse(value_ch)) + Precion_Part;
        }

        //Change the border of Group Box
        public static void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(box.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        //Clear value from comma separator and symbol of pound
        public static string ClearString(string InitialValue)
        {
            return InitialValue = InitialValue.Replace(Program.SymbolPounds, "").Replace(Constant.comma_separator, "");
        }


        public static void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                if (dataGridView.Rows.Count > 0)
                {
                    //Microsoft Office Interop Excel Reference about exporting to excel
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    //Set Header Of Excel
                    for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    }

                    //Insert the values of Grid View
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                XcelApp.Cells[i + 2, j + 1] = Int32.Parse(dataGridView.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                XcelApp.Cells[i + 2, j + 1] = decimal.Parse(ClearString(dataGridView.Rows[i].Cells[j].Value.ToString()));
                            }
                        }
                    }

                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(LocalResources.UnexpectedErrorText);
            }
        }

        public static void ExportToPdf(DataGridView dataGridView)
        {
            try
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                //Open file dialog
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files|*.pdf";
                dlg.FilterIndex = 0;

                string fileName = string.Empty;

                //Save the table to the specific path of the file dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;

                    Document myDocument = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                    PdfWriter.GetInstance(myDocument, new FileStream(fileName, FileMode.Create));
                    myDocument.Open();
                    myDocument.Add(pdfTable); 
                    myDocument.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(LocalResources.UnexpectedErrorText);
            }
        }
    }
}
