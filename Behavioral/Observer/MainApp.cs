using System;

namespace Patterns.Behavioral.Observer
{
    internal class MainApp
    {
        private static void Main21()
        {
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.Read();
        }
    }
}