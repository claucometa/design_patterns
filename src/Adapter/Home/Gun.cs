using System;

namespace Claucometa.DesignPatterns.Adapter
{
    public class Gun : IGun
    {
        public IGun Fire()
        {
            Console.WriteLine("The gun fired");
            return this;
        }
        
        public IGun Then()
        {
            Console.WriteLine("How fast do you load a gun?");
            return this;
        }

        public IGun Load()
        {
            Console.WriteLine("The gun loaded");
            return this;
        }
    }
}
