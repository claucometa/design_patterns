using System;

namespace Claucometa.DesignPatterns.StateMachine
{
    public class Gate : IGate
    {
        IGateState state;

        public Gate() { }

        public Gate(IGateState state)
        {
            this.state = state;
        }

        public void ChangeState(IGateState state)
        {
            this.state = state;
        }

        public void Enter()
        {
            Console.WriteLine("User is trying to ENTER.");
            state.Enter();
        }

        public void Pay()
        {
            Console.WriteLine("User is trying to PAY.");
            state.Pay();
        }
    }
}
