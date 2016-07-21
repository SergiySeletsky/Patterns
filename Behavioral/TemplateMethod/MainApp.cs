using System;

namespace Patterns.Behavioral.TemplateMethod
{
    internal class MainApp
    {
        private static void Main24()
        {
            DataAccessObject dao;

            dao = new Categories();
            dao.Run();

            dao = new Products();
            dao.Run();

            Console.Read();
        }
    }
}