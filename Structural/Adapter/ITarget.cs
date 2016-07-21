namespace Patterns.Structural.Adapter
{
    /// <summary>
    ///     Интерфейс, который требуется Client
    /// </summary>
    internal interface ITarget
    {
        /// <summary>
        ///     Метод, который нужен Client
        /// </summary>
        void Request();
    }
}