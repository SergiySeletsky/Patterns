using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.Functional
{
    /// <summary>
    /// Functional Chain of Responsibility pattern
    /// </summary>
    /// <typeparam name="T">Type that used in conditions</typeparam>
    public class Chain<T> : Dictionary<Predicate<T>, Action<T>>
    {
        private readonly bool parallel;

        /// <summary>
        /// Creates instance of functional Chain of Responsibility pattern
        /// </summary>
        /// <param name="parallel">Enable when multiple conditions can be true for one case. It will run true conditions in parallel</param>
        public Chain(bool parallel = false)
        {
            this.parallel = parallel;
        }

        /// <summary>
        /// Find all actions by value used in conditions
        /// </summary>
        /// <param name="value">value used in conditions</param>
        /// <returns>Actions filtered</returns>
        public IEnumerable<Action<T>> Find(T value)
        {
            return this.Where(i => i.Key(value)).Select(i => i.Value);
        }

        /// <summary>
        /// Process all actions
        /// </summary>
        /// <param name="value">Value to find and run actions</param>
        public void Process(T value)
        {
            if (parallel)
            {
                Parallel.ForEach(Find(value), action => action(value));
            }
            else
            {
                foreach (var action in Find(value))
                {
                    action(value);
                }
            }
        }
    }

    public class Test
    {
        public Test()
        {
            var chain = new Chain<string>(true)
            {
                { c => c == "123", val => { Thread.Sleep(100); } },
                { c => c.Contains("user"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user6"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user7"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user8"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user9"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user10"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user11"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user12"), val => { Thread.Sleep(100); } },
                { c => c.Contains("user13"), val => { Thread.Sleep(100); } },
            };

            var sw = Stopwatch.StartNew();
            for (var i = 0; i < 10; i++)
            {
                chain.Process("login user");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }

}
