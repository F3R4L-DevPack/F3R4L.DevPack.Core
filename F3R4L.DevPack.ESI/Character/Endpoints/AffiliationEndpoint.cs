using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Constants;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class AffiliationEndpoint
        : ApiEndpoint<IEnumerable<long>, IEnumerable<AffiliationItem>>
    {
        private const string _endpoint
            = "/characters/affiliation/?datasource=tranquility";

        public AffiliationEndpoint()
            : base(string.Concat(StringConstants._esiBaseUrl, _endpoint))
        {
        }
    }
}
