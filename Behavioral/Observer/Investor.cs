using System;

namespace Patterns.Behavioral.Observer
{
    internal class Investor : IInvestor
    {
        private readonly string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public Stock Stock { get; set; }

        #region IInvestor Members

        public void Update(Stock stock)
        {
            Console.WriteLine(
                "Notified {0} of {1}'s " +
                "change to {2:C}",
                name,
                stock.Symbol,
                stock.Price
                );
        }

        #endregion
    }
}