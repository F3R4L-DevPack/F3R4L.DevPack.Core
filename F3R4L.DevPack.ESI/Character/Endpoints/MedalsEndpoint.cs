using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class MedalsEndpoint
        : ESIBaseEndpoint<long, IEnumerable<Medal>>
    {
        private const string _endpointFormat = "/characters/{0}/medals/";
        public MedalsEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
