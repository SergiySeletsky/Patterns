namespace Patterns.Behavioral.Interpreter
{
    internal class Context
    {
        public Context(string input)
        {
            this.Input = input;
        }

        public string Input { get; set; }

        public int Output { get; set; }
    }
}