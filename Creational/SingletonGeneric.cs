using System.Threading;

namespace Patterns.Creational
{
    public static class SingletonGeneric<T> where T : class, new()
    {
        private static T value;

        public static T Get()
        {
            lock (value)
            {
                if (value == null)
                {
                    Interlocked.Exchange(ref value, new T());
                }
                return value;
            }
        }
    }
}