using System;

namespace SingletonExample
{
    /// <summary>
    /// Generic program to run singleton examples
    /// </summary>
    class Program
    {
        /// <summary>
        /// The start point of our application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region ClassicExample
            // get the instances
            var singletonClassic1 = SingletonClassic.GetInstance;
            var singletonClassic2 = SingletonClassic.GetInstance;

            // Test for same instance
            if (singletonClassic1 == singletonClassic2)
            {
                Console.WriteLine("Classic Objects are the same instance");
            }
            #endregion

            #region LazyInitialization
            // get the instances
            var singletonLazy1 = SingletonLazyInitialization.GetInstance();
            var singletonLazy2 = SingletonLazyInitialization.GetInstance();

            // Test for same instance
            if (singletonLazy1 == singletonLazy2)
            {
                Console.WriteLine("Lazy Objects are the same instance");
            }
            #endregion

            #region LazyInitialization
            // get the instances
            var singletonThreadSafe1 = SingletonThreadSafeLazyInitialization.GetInstance();
            var singletonThreadSafe2 = SingletonThreadSafeLazyInitialization.GetInstance();

            // Test for same instance
            if (singletonThreadSafe1 == singletonThreadSafe2)
            {
                Console.WriteLine("Thread-Safe Objects are the same instance");
            }
            #endregion

            #region RealWorldExample
            var balancer1 = LoadBalancer.GetLoadBalancer();
            var balancer2 = LoadBalancer.GetLoadBalancer();
            var balancer3 = LoadBalancer.GetLoadBalancer();
            var balancer4 = LoadBalancer.GetLoadBalancer();

            // Test for same instance
            if (balancer1 == balancer2 && balancer2 == balancer3 && balancer3 == balancer4)
            {
                Console.WriteLine("Same load balancer instance");
            }

            // Load balance 15 requests for a server
            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }
            #endregion
        }
    }
}
