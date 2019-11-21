using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Character.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class AffiliationEndpoint<ITypeBlank, AffiliationItem>
        : ApiEndpoint<ITypeBlank, IEnumerable<AffiliationItem>>
    {
        private const string _endpointFormat
            = "https://esi.evetech.net/latest/characters/{0}/?datasource=tranquility";

        public AffiliationEndpoint(string endpoint) 
            : base(endpoint)
        {
        }
    }
}
