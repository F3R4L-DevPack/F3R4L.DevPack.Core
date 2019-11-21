using F3R4L.DevPack.Api.Endpoints;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task PostAsync<TIn>(IApiEndpoint<TIn, Endpoints.ITypeBlank> endpoint, TIn postData)
        {
            var result = await _httpClient.PostAsync(endpoint.Endpoint,
                new StringContent(_serialiser.Serialise<TIn>(postData), Encoding.UTF8, "application/json")
                );
        }

        public async Task<TOut> PostAsync<TIn, TOut>(IApiEndpoint<TIn, TOut> endpoint, TIn postData)
        {
            var result = await _httpClient.PostAsync(endpoint.Endpoint,
                new StringContent(_serialiser.Serialise<TIn>(postData), Encoding.UTF8, "application/json")
                );
            return _serialiser.Deserialise<TOut>(await result.Content.ReadAsStringAsync());
        }
    }
}
