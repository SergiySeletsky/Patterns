using System;
using System.Collections;

namespace Patterns.Behavioral.Command
{
    internal class User
    {
        private readonly Calculator calculator = new Calculator();
        private readonly ArrayList commands = new ArrayList();
        private int current;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    var command = commands[current++] as Command;
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    var command = commands[--current] as Command;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            Command command = new CalculatorCommand(
                calculator, @operator, operand);
            command.Execute();

            commands.Add(command);
            current++;
        }
    }
}