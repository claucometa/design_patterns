using Claucometa.DesignPatterns.Bridge.Resources;
using System.Text;

namespace Claucometa.DesignPatterns.Bridge.ViewResource.Views
{
    public class LargeView : Bridge<IMediaResource, string>
    {
        public LargeView(IMediaResource resource) : base(resource)
        {
        }

        public override string Build()
        {
            StringBuilder z = new();
            z.AppendLine("### Large View ###");
            z.AppendLine(resource.GetTitle());
            z.AppendLine(resource.GetBigImage());
            z.AppendLine(resource.GetDescription());

            return z.ToString();
        }
    }
}