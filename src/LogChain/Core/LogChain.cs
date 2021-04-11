namespace Claucometa.DesignPatterns.LogChain
{
    public abstract class LogChain
    {
        protected ILogProvider next;

        public ILogProvider Build(ILogProvider next)
        {
            this.next = next;
            return next;
        }
    }
}
