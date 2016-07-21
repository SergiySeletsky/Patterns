namespace Patterns.Creational.AbstractFactory
{
    public interface IFactory<out T> where T : IProduct
    {
        T Create();
    }
}