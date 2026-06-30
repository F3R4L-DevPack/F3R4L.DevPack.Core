using F3R4L.DevPack.Api.Endpoints;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task PutAsync<TIn>(PutEndpoint<TIn> endpoint)
        {
            var result = await _httpClient.PutAsync(endpoint.Address, null);
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(endpoint.Address, endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
        }

        public async Task PutAsync<TIn>(PutEndpoint<TIn> endpoint, TIn request,
            string contentType = "application/json")
        {
            var result = await _httpClient.PutAsync(endpoint.Address,
                new StringContent(_jsonSerialiser.Serialise<TIn>(request), Encoding.UTF8, contentType));
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(endpoint.Address, endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
        }

        public async Task<TOut> PutAsync<TIn, TOut>(PutEndpoint<TIn, TOut> endpoint, TIn requestObject,
            string contentType = "application/json")
            where TIn : class
        {
            var result = await _httpClient.PutAsync(endpoint.Address,
                new StringContent(_jsonSerialiser.Serialise<TIn>(requestObject), Encoding.UTF8, contentType));
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
