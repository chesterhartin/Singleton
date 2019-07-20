namespace SingletonExample
{
    /// <summary>
    /// This shows how to lazy initialze an singleton
    /// </summary>
    public class SingletonLazyInitialization
    {
        /// <summary>
        /// an instance that will be the singleton
        /// </summary>
        private static SingletonLazyInitialization _instance;

        /// <summary>
        /// private constructor
        /// </summary>
        private SingletonLazyInitialization()
        {
            // do all your setup here
        }

        /// <summary>
        /// Get the instance
        /// </summary>
        /// <returns></returns>
        public static SingletonLazyInitialization GetInstance()
        {
            // note: this is NOT thread safe
            if (_instance == null)
            {
                _instance = new SingletonLazyInitialization();
            }

            return _instance;
        }
    }
}
