using System;

namespace Patterns.Behavioral.Visitor
{
    internal class VacationVisitor : IVisitor
    {
        #region IVisitor Members

        public void Visit(Element element)
        {
            var employee = element as Employee;

            Console.WriteLine(
                "{0} {1}'s new vacation days: {2}",
                employee.GetType().Name,
                employee.Name,
                employee.VacationDays
                );
        }

        #endregion
    }
}