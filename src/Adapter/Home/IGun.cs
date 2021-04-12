namespace Claucometa.DesignPatterns.Adapter
{
    public interface IGun // the 'in-house' norma
    {
        IGun Load();
        IGun Then();
        IGun Fire();
    }
}
