using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Bl
{
    public class LoanPaymentsCalculator
    {
        public List<LoanPayment> GetAmortizationSchedule(int periods, double balance, double monthlyRate = (double)3 / 100 / 12)
        {
            var loanPayments = new List<LoanPayment>()
            {
                new LoanPayment
                {
                    Balance = balance
                }
            };

            double monthyPayment = (monthlyRate / (1 - (Math.Pow((1 + monthlyRate), -(periods))))) * balance;


            for (var i = 0; i < periods ; i++)
            {
                var loanPayment = new LoanPayment()
                {
                    MonthyPayment = monthyPayment,
                    InterestForMonth = balance * monthlyRate,
                    Index = i + 1
                };
                loanPayment.PrincipalForMonth = monthyPayment - loanPayment.InterestForMonth;
                balance -= loanPayment.PrincipalForMonth;
                loanPayment.Balance = balance;

                loanPayments.Add(loanPayment);
            }

            return loanPayments;
        }
    }
}
