using System;

namespace Patterns.Creational.Lazy
{
    public class App
    {
        public void Test()
        {
            var lazyInteger = new Lazy<int>();
            int integer = lazyInteger.Value;
        }
    }
}