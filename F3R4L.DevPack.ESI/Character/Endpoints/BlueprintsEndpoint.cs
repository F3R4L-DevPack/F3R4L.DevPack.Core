using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Constants;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class BlueprintsEndpoint
        : ApiEndpoint<ITypeBlank, IEnumerable<Blueprint>>
    {
        private const string _endpointFormat = "/characters/{character_id}/blueprints/";

        public BlueprintsEndpoint(long characterId)
            : base(string.Concat(StringConstants._esiBaseUrl, 
                string.Format(_endpointFormat, characterId)))
        {
        }
    }
}
