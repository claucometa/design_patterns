
using Claucometa.DesignPatterns.Bridge.Resources;
using System.Text;

namespace Claucometa.DesignPatterns.Bridge.ZooResource.Views
{
    public class SmallView : Bridge<IZooResource, string>
    {
        public SmallView(IZooResource resource) : base(resource)
        {
        }

        public override string Build()
        {
            StringBuilder z = new();
            z.AppendLine("### Small View ###");
            z.AppendLine(resource.GetTitle());
            z.AppendLine(resource.GetSmallImage());
            return z.ToString();
        }
    }
}
