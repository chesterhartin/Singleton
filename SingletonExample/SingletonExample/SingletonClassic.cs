namespace SingletonExample
{
    /// <summary>
    /// This is probably the most classic structural example of a singleton
    /// </summary>
    public sealed class SingletonClassic
    {
        // Static members are eagerly initialized, that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly SingletonClassic _instance = new SingletonClassic();

        /// <summary>
        /// private constructor
        /// </summary>
        private SingletonClassic()
        {
            // do all your setup here
        }

        /// <summary>
        /// Get the instance
        /// </summary>
        public static SingletonClassic GetInstance
        {
            get
            {
                return _instance;
            }
        }
    }
}
