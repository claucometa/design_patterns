namespace Claucometa.DesignPatterns.LogChain.Application
{
    public class LogContext
    {
        static readonly ILogProvider provider = new LogChainHead();

        static LogContext()
        {
            provider.Build(new LogToConsole1())
                    .Build(new LogToConsole2())
                    .Build(new LogToConsole3());
        }

        public static void Log(string msg, LogType type = LogType.@default)
        {
            provider.Log(msg, type);
        }
    }
}
