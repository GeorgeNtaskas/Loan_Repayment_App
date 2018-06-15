using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanRepaymentApp
{
    //--CONSTANT VARIABLES THAHT NEVER CHANGE, USED FOR DIFFERENT CASES--//
    static class Constant
    {
        public const int MonthsOhYear = 12;
        public const string copyrightUnicode = "00A3";
        public const string comma_separator = ",";
        public const string BasicStringFormat = "{0:0.00}";
    }

    static class Program
    {
        public static string SymbolPounds { get; set; }
        public static CultureInfo Culture { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Set the symbol of project
            int symbol_value = int.Parse(Constant.copyrightUnicode, System.Globalization.NumberStyles.HexNumber);
            SymbolPounds = char.ConvertFromUtf32(symbol_value).ToString();

            //Set the Culture of project
            Culture = new System.Globalization.CultureInfo("en-US");

            Application.Run(new MainForm());
        }
    }
}
