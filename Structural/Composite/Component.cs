namespace Patterns.Structural.Composite
{
    /// <summary>
    ///     Реализует операции, которые применимы к одиночному объекту, т.е. объекту который уже не может быть разбит на составляющие.
    /// </summary>
    internal class Component : IComponent
    {
        public void Operation()
        {
        }
    }
}