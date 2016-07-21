namespace Patterns.Structural.Decorator
{
    /// <summary>
    ///     Интерфейс, который соответствует типу декорируемых объектов (Компонент один из них)
    /// </summary>
    internal interface IComponent
    {
        /// <summary>
        ///     Метод(ы) интерфейса IComponent, который будет переопределен.
        /// </summary>
        void Operation();
    }
}