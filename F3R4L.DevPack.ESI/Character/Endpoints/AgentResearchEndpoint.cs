using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Constants;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class AgentResearchEndpoint
        : ApiEndpoint<ITypeBlank, IEnumerable<AgentResearchItem>>
    {
        private const string _endpointFormat
            = "https://esi.evetech.net/latest/characters/{0}/agents_research/?datasource=tranquility";

        public AgentResearchEndpoint(long characterId)
            : base(string.Concat(StringConstants._esiBaseUrl,
                string.Format(_endpointFormat, characterId)))
        {
        }
    }
}
