using System;

namespace patterns.library.Singleton
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(Init);

        // Singleton instance accessor
        public static LazySingleton Instance => instance.Value;

        // Can obtain instance only through Singleton accessor.
        private LazySingleton()
        {
        }

        private static LazySingleton Init()
        {
            return new LazySingleton();
        }
    }
}