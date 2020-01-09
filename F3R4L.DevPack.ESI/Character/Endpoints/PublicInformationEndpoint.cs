using F3R4L.DevPack.ESI.Shared;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class PublicInformationEndpoint
        : ESIBaseEndpoint<long, Models.Character>
    {
        private const string _endpointFormat 
            = "/characters/{0}/?datasource=tranquility";

        public PublicInformationEndpoint()
            : base(_endpointFormat)
        {
        }
    }
}
