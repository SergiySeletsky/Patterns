namespace Patterns.Creational.AbstractFactory
{
    public class Factory<T> : IFactory<IProduct> where T : IProduct, new()
    {
        public IProduct Create()
        {
            return new T();
        }
    }
}