using System;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal class VicePresident : Approver
    {
        public VicePresident()
        {
            Purchase += VicePresidentRequest;
        }

        public void VicePresidentRequest(Approver approver,
                                         PurchaseEventArgs e)
        {
            if (e.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                                  GetType().Name, e.Number);
            }
            else if (successor != null)
            {
                successor.OnPurchase(e);
            }
        }
    }
}