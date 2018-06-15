using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanRepaymentApp
{
    class LoanFormulas
    {
        //These transformation takes place, thus the Math.Pow does not accept decimal values
        public static decimal DecimalPower(decimal x, int y)
        {
            Double X = (double)x;
            Double Y = (double)y;
            return (decimal)System.Math.Pow(X, Y);
        }

        //Payment Formula is: (Annual interest rate * Loan Amount) / [1 - (1 + Annual Interest Rate) ^ -Loan Period]
        //Payment Formula Simplified Version is: [(Annual interest rate * Loan Amount) * (1 + Annual Interest Rate) ^ Loan Period] / [(1 + Annual Interest Rate) ^ Loan Period] - 1
        public static decimal Payment(decimal LoanAmount, decimal AnnualInterestRate, int LoanPeriod)
        {
            decimal FinalOutcome;

            try
            {
                //(Annual interest rate *Loan Amount)
                decimal Rn_Mult_A = AnnualInterestRate * LoanAmount;

                //(1 + Annual Interest Rate) ^ Loan Period
                decimal Rn_Power_N = DecimalPower((1 + AnnualInterestRate), LoanPeriod);

                decimal FractionFirstPart = Rn_Mult_A * Rn_Power_N;
                decimal FractionSecondPart = Rn_Power_N - 1;

                //Payment Amount Result
                //Round to two decimals
                FinalOutcome = Math.Round((FractionFirstPart / FractionSecondPart), 2);

                return FinalOutcome;
            }
            catch (Exception e)
            {
                MessageBox.Show(LocalResources.UnexpectedErrorText);
                return FinalOutcome = 0;
            }
        }

        //Principal Amount Paid Formula is: Payment(n) * (1 + Annual Interest Rate) ^ - (1 + Loan Period - n)
        //Principal Amount Paid Simplified Version is: Payment(n) / (1 + Annual Interest Rate) ^ (1 + Loan Period - n)
        public static decimal PrincipalAmount(int n,decimal Payment, decimal AnnualInterestRate, int LoanPeriod)
        {
            decimal FinalOutcome;
            try
            {
                //(1 + Annual Interest Rate) ^ Loan Period
                decimal Rn_Power_N =  DecimalPower((1 + AnnualInterestRate), 1 + LoanPeriod - n);

                decimal FractionFirstPart = Payment;
                decimal FractionSecondPart = Rn_Power_N;

                //Principal Amount Paid Result
                //Round to two decimals
                FinalOutcome = Math.Round((FractionFirstPart / FractionSecondPart), 2);

                return FinalOutcome;
            }
            catch (Exception e)
            {
                MessageBox.Show(LocalResources.UnexpectedErrorText);
                return FinalOutcome = 0;
            }
        }

        //Interest Amount Paid Formula is: Payment(n) - Principal Amount(n)
        public static decimal InterestAmountPaid(decimal Payment, decimal PrincipalAmount)
        {
            decimal FinalOutcome;
            try
            {
                //Interest Amount Paid Result
                //Round to two decimals
                FinalOutcome = Math.Round((Payment - PrincipalAmount), 2);
                return FinalOutcome;
            }
            catch (Exception e)
            {
                MessageBox.Show(LocalResources.UnexpectedErrorText);
                return FinalOutcome = 0;
            }
        }

        //Loan Outstanding Balance Formula is: (Interest Amount Paid(n) / Annual Interest Rate) - Principal Amount Paid(n)
        public static decimal LoanOutstandingBalance(decimal InterestAmountPaid, decimal AnnualInterestRate, decimal PrincipalAmount)
        {
            decimal FinalOutcome = 0;
            try
            {
                decimal FractionFirstPart = InterestAmountPaid / AnnualInterestRate;
                decimal FractionSecondPart = PrincipalAmount;

                //Loan Outstanding Balance Result
                //Round to two decimals
                FinalOutcome = Math.Round((FractionFirstPart - FractionSecondPart), 2);

                return FinalOutcome;
            }
            catch (Exception e)
            {
                MessageBox.Show(LocalResources.UnexpectedErrorText);
                return FinalOutcome = 0;
            }

        }
    }
}
