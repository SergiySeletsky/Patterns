using System;
using System.Collections;

namespace Patterns.Behavioral.Visitor
{
    internal class Employees
    {
        private readonly ArrayList employees = new ArrayList();

        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}