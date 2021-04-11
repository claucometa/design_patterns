using System;

namespace Claucometa.DesignPatterns.StateMachine
{
    public class ProcessingGateState : IGateState
    {
        private readonly IGate gate;

        public ProcessingGateState(IGate gate)
        {
            Console.WriteLine("The payment is being processed");
            this.gate = gate;
        }

        public void Enter()
        {
            Console.WriteLine("You shall not pass. The gate is processing.");
        }

        public void Pay()
        {
            Console.WriteLine("Yours payment is being processed.");
            if (ProcessPayment.Run())
                PayOk();
            else
                PayFailed();
        }

        void PayFailed()
        {
            Console.WriteLine("Yours payment failed.");
            gate.ChangeState(new ClosedGateState(gate));
        }

        void PayOk()
        {
            Console.WriteLine("Yours payment was succesfull.");
            gate.ChangeState(new OpenGateState(gate));
        }
    }
}
