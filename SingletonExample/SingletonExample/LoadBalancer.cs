using System;
using System.Collections.Generic;

namespace SingletonExample
{
    /// <summary>
    /// A load balancer as a singleton
    /// </summary>
    public sealed class LoadBalancer
    {
        // Static members are eagerly initialized, that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        static readonly LoadBalancer _instance = new LoadBalancer();

        // Type-safe generic list of servers
        List<Server> _servers;

        // an instance of the random class
        Random random = new Random();

        /// <summary>
        /// private constructor that loads in a list of servers available 
        /// </summary>
        private LoadBalancer()
        {
            // Load list of available servers - this could be loaded from a config file, db, etc
            _servers = new List<Server>
                {
                  new Server{ Name = "ServerI", IP = "120.14.220.18" },
                  new Server{ Name = "ServerII", IP = "120.14.220.19" },
                  new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                  new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                  new Server{ Name = "ServerV", IP = "120.14.220.22" },
                };
        }

        /// <summary>
        /// Get the instance of the load balancer
        /// </summary>
        /// <returns>Instance of a load balancer</returns>
        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }


        /// <summary>
        /// simple, but effective load balancer
        /// </summary>
        public Server NextServer
        {
            get
            {
                int r = random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
