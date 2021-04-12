namespace Claucometa.DesignPatterns.Adapter
{
    public class BazookaAdapter : IGun
        {
            private readonly RealBazooka bazooka;

            public BazookaAdapter(RealBazooka bazooka)
            {
                this.bazooka = bazooka;
            }

            public void Fire()
            {
                bazooka.PutInTheShoulder();
                bazooka.TakeABreath();
                bazooka.FireTheFknBazooka();
            }

            public void Load()
            {
                bazooka.TakeTheHeavyMissile();
                bazooka.LoadInTheBack();
            }
        }
 
}
