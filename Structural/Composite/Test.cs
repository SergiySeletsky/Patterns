namespace Patterns.Structural.Composite
{
    internal class Test
    {
        private static void Do()
        {
            var composite = new Composite();
            var component = new Component();
            component.Operation();
            composite.Add(component);
            composite.Operation();
        }
    }
}