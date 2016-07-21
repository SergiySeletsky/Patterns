namespace Patterns.Structural.Proxy
{
    internal class Test
    {
        private static void Do()
        {
            var proxy = new Proxy();
            object obj = proxy.Request();
        }
    }
}