namespace Patterns.Structural.Adapter
{
    /// <summary>
    ///     Класс, который реализует ITarget в соответствие с Adaptee
    /// </summary>
    internal class Adapter : ITarget
    {
        private Adaptee adaptee;

        public void Request()
        {
            adaptee = new Adaptee();
            adaptee.SpecificRequest();
        }
    }
}