using System;

namespace Patterns.Behavioral.Memento
{
    internal class SalesProspect
    {
        private double budget;
        private string name;
        private string phone;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                Console.WriteLine("Name:   " + name);
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                Console.WriteLine("Phone:  " + phone);
            }
        }

        public double Budget
        {
            get { return budget; }
            set
            {
                budget = value;
                Console.WriteLine("Budget: " + budget);
            }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(name, phone, budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}