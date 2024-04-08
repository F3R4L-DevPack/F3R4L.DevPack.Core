using F3R4L.DevPack.Api.Endpoints;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task PatchAsync<TIn>(PatchEndpoint<TIn> endpoint)
        {
            var result = await _httpClient.PatchAsync(endpoint.Address, null);
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(endpoint.Address, endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
        }

        public async Task PatchAsync<TIn>(PatchEndpoint<TIn> endpoint, TIn request)
        {
            var result = await _httpClient.PatchAsync(endpoint.Address,
                new StringContent(_jsonSerialiser.Serialise<TIn>(request), Encoding.UTF8, "application/json"));
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(endpoint.Address, endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
        }

        public async Task<TOut> PatchAsync<TIn, TOut>(PatchEndpoint<TIn, TOut> endpoint, TIn requestObject)
            where TIn : class
        {
            var result = await _httpClient.PatchAsync(endpoint.Address,
                new StringContent(_jsonSerialiser.Serialise<TIn>(requestObject), Encoding.UTF8, "application/json"));
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(endpoint.Address, endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
            var contentString = await result.Content.ReadAsStringAsync();
            return _jsonSerialiser.Deserialise<TOut>(contentString);
        }
    }
}
