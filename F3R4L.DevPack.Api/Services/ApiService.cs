using F3R4L.DevPack.Api.Factories;
using F3R4L.DevPack.Api.Wrappers;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService : IApiService
    {
        private readonly IHttpClientGenerationFactory _httpClientGenerationFactory;
        private readonly IJsonSerialisationWrapper _serialiser;

        private readonly HttpClient _httpClient;

        public HttpRequestHeaders Headers
        {
            get
            {
                return _httpClient.DefaultRequestHeaders;
            }
        }

        public ApiService(IHttpClientGenerationFactory httpClientGenerationFactory, IJsonSerialisationWrapper serialiser)
        {
            _httpClientGenerationFactory = httpClientGenerationFactory;
            _serialiser = serialiser;

            _httpClient = _httpClientGenerationFactory.CreateClient();
        }

        public void SetHeaders(Dictionary<string, string> headers)
        {
            Headers.Clear();
            headers.ToList().ForEach(header 
                => Headers.Add(header.Key, header.Value));
        }
    }
}
