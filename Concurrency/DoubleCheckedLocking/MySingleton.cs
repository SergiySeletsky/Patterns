using System;

namespace Patterns.Concurrency.DoubleCheckedLocking
{
    public class MySingleton
    {
        private static readonly Lazy<MySingleton> mySingleton =
            new Lazy<MySingleton>(() => new MySingleton());

        private MySingleton()
        {
        }

        public static MySingleton GetInstance()
        {
            return mySingleton.Value;
        }
    }
}