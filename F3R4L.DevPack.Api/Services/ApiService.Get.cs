using F3R4L.DevPack.Api.Endpoints;
using System;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task<TOut> GetAsync<TOut>(IApiEndpoint<Endpoints.ITypeBlank, TOut> apiEndpoint)
        {
            var result = await _httpClient.GetAsync(apiEndpoint.Endpoint);
            return _serialiser.Deserialise<TOut>(await result.Content.ReadAsStringAsync());
        }

        public async Task<TOut> GetAsync<TIn, TOut>(IApiEndpoint<TIn, TOut> apiEndpoint, TIn request)
        {
            if (!IsSimple(typeof(TIn)))
            {
                throw new NotImplementedException("This method does not currently handle complex objects.");
            }

            var result = await _httpClient.GetAsync(apiEndpoint.AddParameters(new object[] { request }));
            return _serialiser.Deserialise<TOut>(await result.Content.ReadAsStringAsync());
        }
    }
}
