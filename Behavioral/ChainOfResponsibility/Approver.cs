namespace Patterns.Behavioral.ChainOfResponsibility
{
    internal abstract class Approver
    {
        protected Approver successor;

        public Approver Successor
        {
            set { successor = value; }
        }

        public event PurchaseEventHandler<Approver, PurchaseEventArgs> Purchase;

        public virtual void OnPurchase(PurchaseEventArgs e)
        {
            if (Purchase != null)
            {
                Purchase(this, e);
            }
        }

        public void ProcessRequest(Purchase purchase)
        {
            OnPurchase(new PurchaseEventArgs(
                           purchase.Number,
                           purchase.Amount,
                           purchase.Purpose)
                );
        }
    }
}