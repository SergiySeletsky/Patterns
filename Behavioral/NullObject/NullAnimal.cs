namespace Patterns.Behavioral.NullObject
{
    // The Null Case: this NullAnimal class should be instantiated and used in place of C# null keyword.
    internal class NullAnimal : IAnimal
    {
        public void MakeSound()
        {
            // Purposefully provides no behaviour.
        }
    }
}