using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class CorporationHistoryEndpoint<ITypeBlank, CorporationHistory>
        : ApiEndpoint<ITypeBlank, IEnumerable<CorporationHistoryItem>>
    {
        private const string _endpointFormat
            = "https://esi.evetech.net/latest/characters/{0}/corporationhistory/?datasource=tranquility";

        public CorporationHistoryEndpoint(long characterId) 
            : base(string.Format(_endpointFormat, characterId))
        {
        }
    }
}
