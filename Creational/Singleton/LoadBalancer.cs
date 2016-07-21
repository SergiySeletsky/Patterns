using System;
using System.Collections;

namespace Patterns.Creational.Singleton
{
    internal class LoadBalancer
    {
        private static LoadBalancer instance;
        private static readonly object syncLock = new object();
        private readonly Random random = new Random();
        private readonly ArrayList servers = new ArrayList();

        protected LoadBalancer()
        {
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }

            return instance;
        }
    }
}