using F3R4L.DevPack.Api.Endpoints;
using System.Net.Http;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task<TOut> SendAsync<TOut>(HttpRequestMessage request)
        {
            var response = await _httpClient.SendAsync(request);

            return _jsonSerialiser.Deserialise<TOut>(await response.Content.ReadAsStringAsync());
        }
    }
}
