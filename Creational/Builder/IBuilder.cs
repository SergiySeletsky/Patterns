namespace Patterns.Creational.Builder
{
    /// <summary>
    ///     Интерфейс, описывающий действия с тем, что должно быть построено
    /// </summary>
    internal interface IBuilder
    {
        void BuildPart();
        IProduct GetResult();
    }
}