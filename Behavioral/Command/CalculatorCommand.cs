namespace Patterns.Behavioral.Command
{
    internal class CalculatorCommand : Command
    {
        private readonly Calculator calculator;
        private int operand;
        private char @operator;

        public CalculatorCommand(Calculator calculator,
                                 char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        public char Operator
        {
            set { @operator = value; }
        }

        public int Operand
        {
            set { operand = value; }
        }

        public override void Execute()
        {
            calculator.Operation(@operator, operand);
        }

        public override void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }

        private char Undo(char @operator)
        {
            char undo;
            switch (@operator)
            {
                case '+':
                    undo = '-';
                    break;
                case '-':
                    undo = '+';
                    break;
                case '*':
                    undo = '/';
                    break;
                case '/':
                    undo = '*';
                    break;
                default:
                    undo = ' ';
                    break;
            }
            return undo;
        }
    }
}