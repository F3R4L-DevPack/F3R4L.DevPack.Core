using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.SSO.Models;
using System.Net.Http;

namespace F3R4L.DevPack.SSO.Endpoints
{
    public class TokenRefreshEndpoint : IApiEndpoint<HttpRequestMessage, TokenResponse>
    {
        public TokenRefreshEndpoint(string endpoint) : base(endpoint)
        {
        }

        public string Endpoint => throw new System.NotImplementedException();

        public string AddParameters(object[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}