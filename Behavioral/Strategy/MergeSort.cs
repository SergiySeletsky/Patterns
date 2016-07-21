using System;
using System.Collections;

namespace Patterns.Behavioral.Strategy
{
    internal class MergeSort : ISortStrategy
    {
        public void Sort(IEnumerable list)
        {
            Console.WriteLine("MergeSorted list ");
        }
    }
}