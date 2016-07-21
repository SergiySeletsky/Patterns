using System;

namespace Patterns.Creational.FactoryMethod
{
    internal class MainApp
    {
        private void Do()
        {
            var documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                Console.WriteLine(
                    "\n{0}--", document.GetType().Name
                    );
                foreach (IPage page in document.Pages)
                {
                    Console.WriteLine(
                        " {0}", page.GetType().Name
                        );
                }
            }
            Console.Read();
        }
    }
}