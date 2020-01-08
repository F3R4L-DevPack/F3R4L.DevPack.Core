using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Constants;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class JumpFatigueEndpoint
        : ApiEndpoint<ITypeBlank, JumpInformation>
    {
        private const string _endpointFormat = "/characters/{0}/fatigue/";

        public JumpFatigueEndpoint(long characterId)
            : base(string.Concat(StringConstants._esiBaseUrl,
                string.Concat(StringConstants._esiBaseUrl, string.Format(_endpointFormat, characterId))))
        {
        }
    }
}
