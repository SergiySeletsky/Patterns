using System.Collections;

namespace Patterns.Creational.FactoryMethod
{
    internal abstract class Document
    {
        private readonly ArrayList pages = new ArrayList();

        public Document()
        {
            CreatePages();
        }

        public ArrayList Pages
        {
            get { return pages; }
        }

        public abstract void CreatePages();
    }
}