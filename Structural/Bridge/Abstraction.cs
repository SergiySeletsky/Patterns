namespace Patterns.Structural.Bridge
{
    /// <summary>
    ///     Интерфейс, который видит клиент
    /// </summary>
    internal class Abstraction
    {
        private readonly IBridge bridge;

        public Abstraction(IBridge implementation)
        {
            bridge = implementation;
        }

        /// <summary>
        ///     Метод, который вызывается клиентом
        /// </summary>
        public void Operation()
        {
            bridge.OperationImp();
        }
    }
}