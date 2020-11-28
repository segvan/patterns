using System.Threading;

namespace patterns.library.Singleton
{
    public class PerThreadSingleton
    {
        private static ThreadLocal<PerThreadSingleton> threadInstance = new ThreadLocal<PerThreadSingleton>(Init);

        public static PerThreadSingleton Instance = threadInstance.Value;

        private PerThreadSingleton()
        {
        }

        private static PerThreadSingleton Init()
        {
            return new PerThreadSingleton();
        }
    }
}