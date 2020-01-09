using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class AgentResearchEndpoint
        : ESIBaseEndpoint<long, IEnumerable<AgentResearchItem>>
    {
        private const string _endpointFormat
            = "/characters/{0}/agents_research/?datasource=tranquility";

        public AgentResearchEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
