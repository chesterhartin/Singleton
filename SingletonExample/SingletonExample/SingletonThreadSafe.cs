using System;

namespace SingletonExample
{
    /// <summary>
    /// A thread-safe version of a singleton
    /// </summary>
    public class SingletonThreadSafeLazyInitialization
    {
        /// <summary>
        /// an instance that will be the singleton
        /// </summary>
        private static SingletonThreadSafeLazyInitialization _instance;
        private static Object _classLock = typeof(SingletonThreadSafeLazyInitialization);

        /// <summary>
        /// private constructor
        /// </summary>
        private SingletonThreadSafeLazyInitialization()
        {
            // do all your setup here
        }

        /// <summary>
        /// Get the instance. Thread safe :D
        /// </summary>
        public static SingletonThreadSafeLazyInitialization GetInstance()
        {
            lock (_classLock)
            {
                if (_instance == null)
                {
                    _instance = new SingletonThreadSafeLazyInitialization();
                }
                return _instance;
            }
        }
    }
}
