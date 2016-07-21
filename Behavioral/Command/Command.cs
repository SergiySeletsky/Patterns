namespace Patterns.Behavioral.Command
{
    internal abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}