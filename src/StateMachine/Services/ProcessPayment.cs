using System;

namespace Claucometa.DesignPatterns.StateMachine
{
    class ProcessPayment
    {
        static Random random = new Random();

        public static bool Run()
        {
            var g = random.Next(0, 2);
            return g == 0;
        }
    }
}
