using System;

namespace Patterns.Behavioral.Visitor
{
    internal class MainApp
    {
        private static void Main25()
        {
            var e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
            Console.Read();
        }
    }
}