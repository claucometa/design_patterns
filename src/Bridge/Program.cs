using Claucometa.DesignPatterns.Bridge.ViewResource.MediaResources;
using Claucometa.DesignPatterns.Bridge.ViewResource.Views;
using System;
using System.Text;

namespace Claucometa.DesignPatterns.Bridge
{
    public class Program
    {
        public static void Run()
        {
            StringBuilder x = new();
            x.AppendLine(new SmallView(new AlbumResource()).Build());
            x.AppendLine(new LargeView(new AlbumResource()).Build());
            x.AppendLine(new SmallView(new ArtistResource()).Build());
            x.AppendLine(new LargeView(new ArtistResource()).Build());
            x.AppendLine(new SmallView(new SongResource()).Build());
            x.AppendLine(new LargeView(new SongResource()).Build());
            Console.WriteLine(x.ToString());
        }
    }
}
