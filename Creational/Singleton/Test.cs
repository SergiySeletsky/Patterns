using System;

namespace Patterns.Creational.Singleton
{
    internal class Test
    {
        private void Do()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(b1.Server);
            }
            Console.Read();
        }
    }
}