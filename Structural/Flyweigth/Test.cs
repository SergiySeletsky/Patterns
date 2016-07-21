using System;
using System.Linq;

namespace Patterns.Structural.Flyweigth
{
    internal class Test
    {
        private static void Do()
        {
            const string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();
            var factory = new FlyweightFactory();

            foreach (IFlyweight flyweight in chars.Select(factory.GetCharacter))
            {
                flyweight.Display();
            }
            Console.Read();
        }
    }
}