namespace Claucometa.DesignPatterns.Adapter
{
    public class Program
    {    
        public static void Run()
        {
            IGun gun = new Gun();
            gun.Load().Then().Fire();

            // The client don't know how to handle a bazooka, only a gun, what now?
            // ... that won't be a problem with the BazookaAdapter,
            // that makes a Bazooka to operate as simply as a gun

            IGun bazooka = new BazookaAdapter(new RealBazooka());
            bazooka.Load().Then().Fire();
        }
    } 
}
