using Claucometa.DesignPatterns.Bridge.Resources;
using System;

namespace Claucometa.DesignPatterns.Bridge.ZooResource.MediaResources
{
    public class SongResource : IMediaResource
    {
        public string GetBigImage()
        {
            return "Big song image";
        }

        public string GetDescription()
        {
            return "song description";
        }

        public string GetSmallImage()
        {
            return "Small song image";
        }

        public string GetTitle()
        {
            return "song title";
        }
    }
}
