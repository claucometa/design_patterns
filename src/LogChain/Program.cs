using Claucometa.DesignPatterns.LogChain.Application;
using System;

namespace Claucometa.DesignPatterns.LogChain
{
    public class Program
    {
        public static void Run()
        {
            LogContext.Log("ola");
            LogContext.Log("ola", LogType.error);
            LogContext.Log("ola", LogType.warning);
            LogContext.Log("ola", LogType.information);
        }
    }
}
