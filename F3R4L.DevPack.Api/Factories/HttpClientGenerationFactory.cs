using System.Net.Http;

namespace F3R4L.DevPack.Api.Factories
{
    public class HttpClientGenerationFactory : IHttpClientGenerationFactory
    {
        public HttpClient CreateClient()
        {
            return new HttpClient();
        }
    }
}
