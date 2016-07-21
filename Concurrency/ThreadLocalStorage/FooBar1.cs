using System;

namespace Patterns.Concurrency.ThreadLocalStorage
{
    internal class FooBar1
    {
        [ThreadStatic] private static int foo;
    }
}