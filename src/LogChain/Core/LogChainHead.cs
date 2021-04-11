namespace Claucometa.DesignPatterns.LogChain
{
    internal class LogChainHead : LogChain, ILogProvider
    {
        public void Log(string msg, LogType type)
        {
            if (next != null) next.Log(msg, type);
        }
    }
}
