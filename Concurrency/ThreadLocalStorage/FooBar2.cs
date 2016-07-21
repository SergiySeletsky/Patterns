using System.Threading;

namespace Patterns.Concurrency.ThreadLocalStorage
{
    internal class FooBar2
    {
        private static ThreadLocal<int> foo;
    }
}