namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class Purchase
    {
        public Purchase(int number, double amount, string purpose)
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