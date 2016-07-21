namespace Patterns.Structural.Decorator
{
    internal class Client : Decorator
    {
        public Client(IComponent component) : base(component)
        {
        }
    }
}