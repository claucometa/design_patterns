namespace Claucometa.DesignPatterns.StateMachine
{
    public interface IGate: IGateState
    {
        void ChangeState(IGateState state);
    }
}