using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class AffiliationEndpoint
        : ESIBaseEndpoint<IEnumerable<long>, IEnumerable<AffiliationItem>>
    {
        private const string _endpoint
            = "/characters/affiliation/?datasource=tranquility";

        public AffiliationEndpoint()
            : base(_endpoint)
        {
        }
    }
}
