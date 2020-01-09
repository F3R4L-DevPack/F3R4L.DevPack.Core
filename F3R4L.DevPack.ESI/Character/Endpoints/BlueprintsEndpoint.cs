using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class BlueprintsEndpoint
        : ApiEndpoint<long, IEnumerable<Blueprint>>
    {
        private const string _endpointFormat = "/characters/{0}/blueprints/";

        public BlueprintsEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
