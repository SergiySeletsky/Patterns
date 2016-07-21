using System;

namespace Patterns.Structural.Facade
{
    internal class Test
    {
        private void Do()
        {
            var mortgage = new Mortgage();
            var customer = new Customer("Ann McKinsey");
            bool eligable = mortgage.IsEligible(customer, 125000);

            Console.WriteLine(
                "\n{0} has been {1}",
                customer.Name,
                (eligable ? "Approved" : "Rejected")
                );

            Console.Read();
        }
    }
}