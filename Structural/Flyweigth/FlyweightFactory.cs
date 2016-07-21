using System.Collections.Generic;

namespace Patterns.Structural.Flyweigth
{
    /// <summary>
    ///     Создает и управляет уникальными Приспособленцами.
    /// </summary>
    internal class FlyweightFactory
    {
        private readonly Dictionary<char, IFlyweight> flyweights = new Dictionary<char, IFlyweight>();

        public IFlyweight this[char index]
        {
            get
            {
                //if (!flyweights.ContainsKey(index))
                //{
                //    flyweights[index] = new FlyweightA();
                //}
                return flyweights[index];
            }
        }

        public IFlyweight GetCharacter(char key)
        {
            IFlyweight flyweight = flyweights[key];
            if (flyweight == null)
            {
                switch (key)
                {
                    case 'A':
                        flyweight = new FlyweightA();
                        break;
                    case 'B':
                        flyweight = new FlyweightB();
                        break;
                }
                flyweights.Add(key, flyweight);
            }
            return flyweight;
        }
    }
}