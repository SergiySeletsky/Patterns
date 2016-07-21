using System;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class MainApp
    {
        private static void Main16()
        {
            Purchase purchase;

            Approver Larry = new Director();
            Approver Sam = new VicePresident();
            Approver Tammy = new President();

            Larry.Successor = Sam;
            Sam.Successor = Tammy;

            purchase = new Purchase(2034, 350.00, "Supplies");
            Larry.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10, "Project X");
            Larry.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100.00, "Project Y");
            Larry.ProcessRequest(purchase);

            Console.Read();
        }
    }
}