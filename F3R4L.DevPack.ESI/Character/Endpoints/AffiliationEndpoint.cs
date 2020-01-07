using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class AffiliationEndpoint
        : ApiEndpoint<IEnumerable<long>, IEnumerable<AffiliationItem>>
    {
        private const string _endpoint
            = "https://esi.evetech.net/latest/characters/affiliation/?datasource=tranquility";

        public AffiliationEndpoint() 
            : base(_endpoint)
        {
        }
    }
}
