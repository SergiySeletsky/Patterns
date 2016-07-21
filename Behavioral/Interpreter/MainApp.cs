using System;
using System.Collections;

namespace Patterns.Behavioral.Interpreter
{
    internal class MainApp
    {
        private static void Main18()
        {
            string roman = "MCMXXVIII";
            var context = new Context(roman);

            var tree = new ArrayList();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine(
                "{0} = {1}",
                roman,
                context.Output
                );

            Console.Read();
        }
    }
}