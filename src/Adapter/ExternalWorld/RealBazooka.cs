using System;

namespace Claucometa.DesignPatterns.Adapter
{
    public class RealBazooka
    {
        public void FireTheFknBazooka()
        {
            Console.WriteLine("The Bazooka fired");
        }

        public void LoadInTheBack()
        {
            Console.WriteLine("The Bazooka loaded");
        }

        public void PutInTheShoulder()
        {
            Console.WriteLine("Put it in your shoulder");
        }

        public void TakeABreath()
        {
            Console.WriteLine("Take a deep breath");
        }

        public void TakeTheHeavyMissile()
        {
            Console.WriteLine("Your friend is helping you with the missile");
        }
    }

}
