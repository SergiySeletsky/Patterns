using System;

namespace Patterns.Behavioral.Command
{
    internal class Calculator
    {
        private int curr;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    curr += operand;
                    break;
                case '-':
                    curr -= operand;
                    break;
                case '*':
                    curr *= operand;
                    break;
                case '/':
                    curr /= operand;
                    break;
            }
            Console.WriteLine(
                "Current value = {0,3} (following {1} {2})",
                curr, @operator, operand);
        }
    }
}