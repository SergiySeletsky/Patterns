namespace Patterns.Structural.Decorator
{
    internal class Test
    {
        private static void Do()
        {
            var component = new Component();
            component.Operation();

            var client = new Client(component);
            client.Operation();
            client.AddedBehavior();
        }
    }
}