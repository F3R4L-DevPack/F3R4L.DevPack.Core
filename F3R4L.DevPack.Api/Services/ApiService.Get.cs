using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task<TOut> GetAsync<TOut>(GetEndpoint<TOut> endpoint)
        {
            var result = await _httpClient.GetAsync(endpoint.Address);
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(endpoint.Address, endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
            return _jsonSerialiser.Deserialise<TOut>(await result.Content.ReadAsStringAsync());
        }

        public async Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, TIn request)
            where TIn : IConvertible
        {
            var result = await _httpClient.GetAsync(string.Format(endpoint.Address, request.ToString()));
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(string.Format(endpoint.Address, request.ToString()), endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
            return _jsonSerialiser.Deserialise<TOut>(await result.Content.ReadAsStringAsync());
        }

        public async Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, Dictionary<string, object> requestParameters)
            where TIn : IDictionary<string, object>
        {
            var suffix = requestParameters.ToUrlParameterString();
            var result = await _httpClient.GetAsync(string.Concat(endpoint.Address, "?", suffix));
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(string.Concat(endpoint.Address, "?", suffix), endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
            return _jsonSerialiser.Deserialise<TOut>(await result.Content.ReadAsStringAsync());
        }

        public async Task<TOut> GetAsync<TIn1, TIn2, TOut>(GetEndpoint<TIn1, TIn2, TOut> endpoint, TIn1 request, Dictionary<string, object> requestParameters)
            where TIn1 : IConvertible
            where TIn2 : IDictionary<string, object>
        {
            var suffix = requestParameters.ToUrlParameterString();
            var result = await _httpClient.GetAsync(string.Concat(string.Format(endpoint.Address, request.ToString()), "?", suffix));

            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(string.Concat(string.Format(endpoint.Address, request.ToString()), "?", suffix), endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
            return _jsonSerialiser.Deserialise<TOut>(await result.Content.ReadAsStringAsync());
        }
    }
}
