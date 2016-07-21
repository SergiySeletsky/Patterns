using System;

namespace Patterns.Creational.Prototype
{
    /// <summary>
    ///     Класс с возможностями копирования, исходный элемент
    /// </summary>
    internal class Color : IPrototype
    {
        private readonly int blue;
        private readonly int green;
        private readonly int red;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public IPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", red, green, blue);
            return MemberwiseClone() as IPrototype;
        }
    }
}