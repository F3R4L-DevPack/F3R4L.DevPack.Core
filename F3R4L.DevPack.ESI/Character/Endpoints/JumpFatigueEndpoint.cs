using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class JumpFatigueEndpoint
        : ESIBaseEndpoint<long, JumpInformation>
    {
        private const string _endpointFormat = "/characters/{0}/fatigue/";

        public JumpFatigueEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
