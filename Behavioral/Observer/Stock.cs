using System;
using System.Collections;

namespace Patterns.Behavioral.Observer
{
    internal abstract class Stock
    {
        private readonly ArrayList investors = new ArrayList();
        protected double price;
        protected string symbol;

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                Notify();
            }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public void Attach(Investor investor)
        {
            investors.Add(investor);
        }

        public void Detach(Investor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (Investor investor in investors)
            {
                investor.Update(this);
            }
            Console.WriteLine("");
        }
    }
}