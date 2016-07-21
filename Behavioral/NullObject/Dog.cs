using System;

namespace Patterns.Behavioral.NullObject
{
    // Dog is a real animal.
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}