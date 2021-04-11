using Claucometa.DesignPatterns.Bridge.Resources;
using System;

namespace Claucometa.DesignPatterns.Bridge.ZooResource.MediaResources
{
    public class AlbumResource : IMediaResource
    {
        public string GetBigImage()
        {
            return "Big album image";
        }

        public string GetDescription()
        {
            return "Album description";
        }

        public string GetSmallImage()
        {
            return "Small album image";
        }

        public string GetTitle()
        {
            return "Album title";
        }
    }
}
