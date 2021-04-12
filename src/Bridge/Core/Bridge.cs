namespace Claucometa.DesignPatterns.Bridge
{
    public abstract class Bridge<Resource, Product>
    {
        protected readonly Resource resource;

        public Bridge(Resource resource)
        {
            this.resource = resource;
        }

        public abstract Product Build();
    }
}