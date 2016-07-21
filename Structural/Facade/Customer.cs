namespace Patterns.Structural.Facade
{
    internal class Customer
    {
        private readonly string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}