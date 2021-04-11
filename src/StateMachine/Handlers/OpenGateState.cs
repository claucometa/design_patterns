using System;

namespace Claucometa.DesignPatterns.StateMachine
{
    public class OpenGateState : IGateState
    {
        private readonly IGate gate;

        public OpenGateState(IGate gate)
        {
            Console.WriteLine("The gate is open");
            this.gate = gate;
        }

        public void Enter()
        {
            Console.WriteLine("You entered the gate. Now, it's about to close.");
            gate.ChangeState(new ClosedGateState(gate));
        }

        public void Pay()
        {
            Console.WriteLine("You already paid");
        }
    }
}
