using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.ESI.Constants;

namespace F3R4L.DevPack.ESI.Character.Endpoints
{
    public class PublicInformationEndpoint
        : ApiEndpoint<ITypeBlank, Models.Character>
    {
        private const string _endpointFormat 
            = "https://esi.evetech.net/latest/characters/{0}/?datasource=tranquility";

        public PublicInformationEndpoint(long characterId)
            : base(string.Concat(StringConstants._esiBaseUrl,
                string.Format(_endpointFormat, characterId)))
        {
        }
    }
}
