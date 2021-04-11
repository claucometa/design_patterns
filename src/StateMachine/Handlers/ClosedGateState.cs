using System;

namespace Claucometa.DesignPatterns.StateMachine
{
    public class ClosedGateState : IGateState
    {
        private readonly IGate gate;

        public ClosedGateState(IGate gate)
        {
            Console.WriteLine("The gate is closed");
            this.gate = gate;
        }

        public void Enter()
        {
            Console.WriteLine("You shall not pass. The gate is closed");
        }

        public void Pay()
        {
            gate.ChangeState(new ProcessingGateState(gate));
        }
    }
}
