namespace Singleton
{
    public sealed class Logger
    {
        private static Logger? instance;

        public static Logger Instance
        {
            get
            {
                instance ??= new Logger();
                return instance;
            }
        }

        private Logger() { }

        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}

namespace Singleton.Lazy
{
    public class Logger
    {
        private static readonly Lazy<Logger> lazyLogger = new(() => new Logger());

        public static Logger Instance
        {
            get => lazyLogger.Value;
        }

        protected Logger() { }

        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
