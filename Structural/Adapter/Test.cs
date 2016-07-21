namespace Patterns.Structural.Adapter
{
    internal class Test
    {
        private static void Do()
        {
            ITarget unknown = new Adapter();
            unknown.Request();
        }
    }
}