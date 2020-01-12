using F3R4L.DevPack.ESI.Character.Models;
using F3R4L.DevPack.ESI.Shared;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class CorporationRolesEndpoint
        : ESIBaseEndpoint<long, CorporationRolesCollection>
    {
        private const string _endpointFormat = "/characters/{0}/roles/";

        public CorporationRolesEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
