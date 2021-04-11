using Claucometa.DesignPatterns.Bridge.Resources;
using System;

namespace Claucometa.DesignPatterns.Bridge.ZooResource.MediaResources
{
    public class ArtistResource : IMediaResource
    {
        public string GetBigImage()
        {
            return "Big artist image";
        }

        public string GetDescription()
        {
            return "artist description";
        }

        public string GetSmallImage()
        {
            return "Small artist image";
        }

        public string GetTitle()
        {
            return "artist title";
        }
    }

}
