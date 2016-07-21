namespace Patterns.Structural.Bridge
{
    /// <summary>
    ///     Интерфейс, определяющий те части Абстракции, которые могут меняться.
    /// </summary>
    internal interface IBridge
    {
        void OperationImp();
    }

    //Обратите внимание, что интерфейс Мост должен содержать все операции, которые есть в обеих
}