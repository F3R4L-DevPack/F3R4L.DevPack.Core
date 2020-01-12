using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class StandingsEndpoint
        : ESIBaseEndpoint<long, IEnumerable<StandingItem>>
    {

        private const string _endpointFormat = "/characters/{0}/standings/";
        public StandingsEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
