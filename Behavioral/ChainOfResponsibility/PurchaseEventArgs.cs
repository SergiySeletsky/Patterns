using System;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    public class PurchaseEventArgs : EventArgs
    {
        public PurchaseEventArgs(
            int number,
            double amount,
            string purpose)
        {
            this.Number = number;
            this.Amount = amount;
            this.Purpose = purpose;
        }

        public double Amount { get; set; }

        public string Purpose { get; set; }

        public int Number { get; set; }
    }
}