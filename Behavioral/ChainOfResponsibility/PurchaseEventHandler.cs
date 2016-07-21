namespace Patterns.Behavioral.ChainOfResponsibility
{
    public delegate void PurchaseEventHandler<T, U>(T sender, U eventArgs);
}