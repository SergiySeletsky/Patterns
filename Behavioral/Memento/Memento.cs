namespace Patterns.Behavioral.Memento
{
    internal class Memento : SalesProspect
    {
        public Memento(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }
    }
}