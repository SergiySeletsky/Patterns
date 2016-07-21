using System;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class President : Approver
    {
        public President()
        {
            Purchase += PresidentRequest;
        }

        public void PresidentRequest(
            Approver approver,
            PurchaseEventArgs e)
        {
            if (e.Amount < 100000.0)
            {
                Console.WriteLine(
                    "{0} approved request# {1}",
                    GetType().Name,
                    e.Number
                    );
            }
            else
            {
                Console.WriteLine(
                    "Request# {0} requires an executive meeting!",
                    e.Number);
            }
        }
    }
}