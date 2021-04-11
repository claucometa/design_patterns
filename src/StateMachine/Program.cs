namespace Claucometa.DesignPatterns.StateMachine
{
    class Program
    {
        public static void Run()
        {
            IGate gate = new Gate();
            IGateState initialState = new ClosedGateState(gate);
            gate.ChangeState(initialState);

            for (int i = 0; i < 7; i++)
            {
                gate.Enter();
                gate.Pay();
            }
        }
    }
}
