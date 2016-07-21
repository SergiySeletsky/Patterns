namespace Patterns.Behavioral.NullObject
{
    internal class Program
    {
        private static void Main34()
        {
            IAnimal dog = new Dog();
            dog.MakeSound(); // outputs "Woof!"

            /* Instead of using C# null, use a NullAnimal instance.
             * This example is simplistic but conveys the idea that if a NullAnimal instance is used then the program
             * will never experience a .NET System.NullReferenceException at runtime, unlike if C# null was used.
             */
            IAnimal unknown = new NullAnimal(); //<< replaces: IAnimal unknown = null;
            unknown.MakeSound(); // outputs nothing, but does not throw a runtime exception        
        }
    }
}