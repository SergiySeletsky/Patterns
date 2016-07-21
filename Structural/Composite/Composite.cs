using System.Collections.Generic;

namespace Patterns.Structural.Composite
{
    /// <summary>
    ///     Реализует операции, которые применимы как к составным объектам (композитам) так и к их составляющим
    /// </summary>
    internal class Composite : List<IComponent>, IComponent
    {
        public void Operation()
        {
        }
    }
}