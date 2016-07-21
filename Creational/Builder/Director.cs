namespace Patterns.Creational.Builder
{
    /// <summary>
    ///     Содержит последовательность технологических операций, которая должна быть выполнена, чтобы создать Product
    /// </summary>
    internal class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPart();
        }
    }
}