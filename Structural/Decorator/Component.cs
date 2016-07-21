namespace Patterns.Structural.Decorator
{
    /// <summary>
    ///     Исходный класс, к объектам которого мы хотим добавить новое поведение или модифицировать существующее.
    /// </summary>
    internal class Component : IComponent
    {
        /// <summary>
        ///     Метод(ы) интерфейса IComponent, который будет переопределен.
        /// </summary>
        public void Operation()
        {
        }
    }
}