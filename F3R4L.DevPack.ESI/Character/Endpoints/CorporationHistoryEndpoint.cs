using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class CorporationHistoryEndpoint
        : ESIBaseEndpoint<long, IEnumerable<CorporationHistoryItem>>
    {
        private const string _endpointFormat
            = "/characters/{0}/corporationhistory/?datasource=tranquility";

        public CorporationHistoryEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
