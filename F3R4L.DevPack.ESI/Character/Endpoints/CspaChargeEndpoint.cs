using F3R4L.DevPack.ESI.Shared;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class CspaChargeEndpoint
        : ESIBaseEndpoint<long, IEnumerable<long>, long>
    {
        private const string _endpoint = "/characters/{0}/cspa/";

        public CspaChargeEndpoint()
            : base(_endpoint)
        {
        }
    }
}
