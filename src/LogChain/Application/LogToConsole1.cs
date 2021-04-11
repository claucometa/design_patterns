using System.Diagnostics;

namespace Claucometa.DesignPatterns.LogChain.Application
{
    internal class LogToConsole1 : LogChain, ILogProvider
    {
        public LogToConsole1()
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
        }

        public void Log(string msg, LogType type = LogType.@default)
        {
            msg = "LOG 1: " + msg;

            switch (type)
            {
                case LogType.information:
                    Trace.TraceInformation(msg);
                    break;
                case LogType.warning:
                    Trace.TraceWarning(msg);
                    break;
                case LogType.error:
                    Trace.TraceError(msg);
                    break;
                default:
                    Trace.WriteLine(msg);
                    break;
            }
 
            if (next != null) next.Log(msg, type);
        }
    }
}
