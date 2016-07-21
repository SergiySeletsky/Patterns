using System;

namespace Patterns.Creational.Builder
{
    /// <summary>
    ///     Вызывается Директором, чтобы создать части Продукта
    /// </summary>
    internal class Builder : IBuilder
    {
        public void BuildPart()
        {
            throw new NotImplementedException();
        }

        public IProduct GetResult()
        {
            throw new NotImplementedException();
        }
    }
}