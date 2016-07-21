using System.Collections.Generic;

namespace Patterns.Creational.Prototype
{
    /// <summary>
    ///     Хранит индексированный список клонируемых структур данных.
    /// </summary>
    internal class PrototypeManager
    {
        private readonly IDictionary<string, IPrototype> prototypes = new Dictionary<string, IPrototype>();

        public IPrototype this[string name]
        {
            get { return prototypes[name]; }
            set { prototypes.Add(name, value); }
        }
    }
}