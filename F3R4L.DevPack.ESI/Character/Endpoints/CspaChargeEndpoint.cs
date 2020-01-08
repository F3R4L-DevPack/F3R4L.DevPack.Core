using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Constants;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class CspaChargeEndpoint
        : ApiEndpoint<IEnumerable<long>, long>
    {
        private const string _endpoint
            = "/characters/{0}/cspa/";

        public CspaChargeEndpoint(long characterId)
            : base(string.Concat(StringConstants._esiBaseUrl, string.Format(_endpoint, characterId)))
        {
        }
    }
}
