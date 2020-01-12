using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class PortraitEndpoint
        : ESIBaseEndpoint<long, PortraitInformation>
    {
        private const string _endpointFormat = "/characters/{0}/portrait/";

        public PortraitEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
