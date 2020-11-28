using System.Collections.Generic;

namespace patterns.library.Singleton
{
    public class Singleton
    {
        // Singleton instance
        private static readonly Singleton instance = new Singleton();

        // Singleton instance accessor
        public static Singleton Instance => instance;

        // Can obtain instance only through Singleton accessor.
        private Singleton()
        {
            // Some initialization
        }
    }
}