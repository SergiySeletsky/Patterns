﻿using System;
using System.Collections;

namespace Patterns.Behavioral.Strategy
{
    internal class ShellSort : ISortStrategy
    {
        public void Sort(IEnumerable list)
        {
            Console.WriteLine("ShellSorted list ");
        }
    }
}