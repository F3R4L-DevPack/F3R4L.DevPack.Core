using F3R4L.DevPack.Api.Factories;
using F3R4L.DevPack.Api.Wrappers;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService : IApiService
    {
        private readonly IHttpClientGenerationFactory _httpClientGenerationFactory;
        private readonly IJsonSerialisationWrapper _serialiser;

        private readonly HttpClient _httpClient;

        public ApiService(IHttpClientGenerationFactory httpClientGenerationFactory, IJsonSerialisationWrapper serialiser)
        {
            _httpClientGenerationFactory = httpClientGenerationFactory;
            _serialiser = serialiser;

            _httpClient = _httpClientGenerationFactory.CreateClient();
        }

        public void SetHeaders(Dictionary<string, string> headers)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            headers.ToList().ForEach(header 
                => _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value));
        }
    }
}
