using System;

namespace Claucometa.DesignPatterns.LogChain.Application
{
    internal class LogToConsole2 : LogChain, ILogProvider
    {
        public void Log(string msg, LogType type)
        {
            Console.WriteLine("LOG 2: " + msg);
            if (next != null) next.Log(msg, type);
        }
    }
}
