using System.Collections;

namespace Patterns.Behavioral.Strategy
{
    /// <summary>
    ///     IStrategy - интерфейс для всех алгоритмов, обладающий абстрактным методом
    /// </summary>
    internal interface ISortStrategy
    {
        void Sort(IEnumerable list);
    }
}