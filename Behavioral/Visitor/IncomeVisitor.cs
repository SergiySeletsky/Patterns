using System;

namespace Patterns.Behavioral.Visitor
{
    internal class IncomeVisitor : IVisitor
    {
        #region IVisitor Members

        public void Visit(Element element)
        {
            var employee = element as Employee;

            employee.Income *= 1.10;
            Console.WriteLine(
                "{0} {1}'s new income: {2:C}",
                employee.GetType().Name,
                employee.Name,
                employee.Income
                );
        }

        #endregion
    }
}