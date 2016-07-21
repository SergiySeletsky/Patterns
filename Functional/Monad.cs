using System;

namespace Patterns.Functional
{
    public static class Monad
    {
        public static T Do<T>(this T obj, Action<T> func) where T : class
        {
            if (obj != null)
            {
                func(obj);
            }
            return obj;
        }

        public static TR Exec<T, TR>(this T obj, Func<T, TR> func) where T : class
        {
            return obj == null ? default(TR) : func(obj);
        }

        public static T If<T>(this T obj, Func<T, bool> func) where T : class
        {
            return obj == null || !func(obj) ? default(T) : obj;
        }

        public static TResult With<TSource, TResult>(this TSource source, Func<TSource, TResult> action) where TSource : class
        {
            if (source != default(TSource))
            {
                return action(source);
            }
            else
            {
                return default(TResult);
            }
        }

    }
}