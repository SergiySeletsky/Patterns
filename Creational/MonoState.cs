using System;
using System.Threading;

namespace Patterns.Created
{
    public sealed class MonoState<T> where T : class, new()
    {
        private static readonly Object Lock = new object();
        private static T _value;

        private static T Get()
        {
            if (_value != null) return _value;

            Monitor.Enter(Lock);

            if (_value == null)
            {
                Interlocked.Exchange(ref _value, new T());
            }
            Monitor.Exit(Lock);

            return _value;
        }
    }
}