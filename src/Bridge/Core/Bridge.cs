namespace Claucometa.DesignPatterns.Bridge
{
    public abstract class Bridge<T, R>
    {
        protected readonly T resource;

        public Bridge(T resource)
        {
            this.resource = resource;
        }

        public abstract R Build();
    }
}
