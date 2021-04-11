namespace Claucometa.DesignPatterns.LogChain
{
    public interface ILogProvider
    {
        ILogProvider Build(ILogProvider next);
        void Log(string msg, LogType type);
    }
}
