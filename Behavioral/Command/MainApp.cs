using System;

namespace Patterns.Behavioral.Command
{
    internal class MainApp
    {
        private static void Main17()
        {
            var user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);

            user.Redo(3);

            Console.Read();
        }
    }
}