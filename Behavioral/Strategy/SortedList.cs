using System;
using System.Collections;

namespace Patterns.Behavioral.Strategy
{
    internal class SortedList
    {
        private readonly ArrayList list = new ArrayList();
        private ISortStrategy sortstrategy;

        public void SetSortStrategy(ISortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            sortstrategy.Sort(list);
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}