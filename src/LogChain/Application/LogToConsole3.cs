using System;

namespace Claucometa.DesignPatterns.LogChain.Application
{
    internal class LogToConsole3 : LogChain, ILogProvider
    { 
        public void Log(string msg, LogType type)
        {
            Console.WriteLine("LOG 3: " + msg);
            if (next != null) next.Log(msg, type);
        }
    }
}
