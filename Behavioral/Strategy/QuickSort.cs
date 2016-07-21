using System;
using System.Collections;

namespace Patterns.Behavioral.Strategy
{
    internal class QuickSort : ISortStrategy
    {
        public void Sort(IEnumerable list)
        {
            Console.WriteLine("QuickSorted list ");
        }
    }
}