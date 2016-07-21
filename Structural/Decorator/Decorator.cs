namespace Patterns.Structural.Decorator
{
    /// <summary>
    ///     Класс, который реализует интерфейс IComponent и добавляет к нему новое состояние/поведение.
    /// </summary>
    internal abstract class Decorator : IComponent
    {
        protected IComponent Component;

        protected Decorator(IComponent component)
        {
            Component = component;
        }

        /// <summary>
        ///     Метод(ы) интерфейса IComponent, который будет переопределен.
        /// </summary>
        public void Operation()
        {
        }

        public void AddedBehavior()
        {
        }
    }
}