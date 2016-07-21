namespace Patterns.Creational.Prototype
{
    /// <summary>
    ///     Интерфейс, который определяет, что прототипы должны быть копируемы.
    /// </summary>
    internal interface IPrototype
    {
        IPrototype Clone();
    }
}