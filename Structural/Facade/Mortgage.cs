using System;

namespace Patterns.Structural.Facade
{
    internal class Mortgage
    {
        private readonly Bank bank = new Bank();
        private readonly Credit credit = new Credit();
        private readonly Loan loan = new Loan();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine(
                "{0} applies for {1:C} loan\n",
                cust.Name,
                amount
                );
            bool eligible = true;
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}