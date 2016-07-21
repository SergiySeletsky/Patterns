using Patterns.Creational.AbstractFactory.Product;

namespace Patterns.Creational.AbstractFactory
{
    internal class Test
    {
        public static void Do()
        {
            IFactory<IProduct> factory = new Factory<ProductA>();
            IProduct product = factory.Create();
            product.Operation();
        }
    }
}