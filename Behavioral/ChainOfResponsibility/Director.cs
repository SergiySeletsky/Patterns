using System;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class Director : Approver
    {
        public Director()
        {
            Purchase += DirectorRequest;
        }

        public void DirectorRequest(Approver approver, PurchaseEventArgs e)
        {
            if (e.Amount < 10000.0)
            {
                Console.WriteLine(
                    "{0} approved request# {1}",
                    GetType().Name,
                    e.Number
                    );
            }
            else if (successor != null)
            {
                successor.OnPurchase(e);
            }
        }
    }
}