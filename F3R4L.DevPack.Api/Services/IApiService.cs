using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using F3R4L.DevPack.Api.Endpoints;

namespace F3R4L.DevPack.Api.Services
{
    public interface IApiService
    {
        HttpRequestHeaders Headers { get; }

        Task<TOut> GetAsync<TIn, TOut>(IApiEndpoint<TIn, TOut> apiEndpoint, TIn request);
        Task<TOut> GetAsync<TOut>(IApiEndpoint<ITypeBlank, TOut> apiEndpoint);
        Task<TOut> PostAsync<TIn, TOut>(IApiEndpoint<TIn, TOut> endpoint, TIn postData);
        Task PostAsync<TIn>(IApiEndpoint<TIn, ITypeBlank> endpoint, TIn postData);
        Task<TOut> PostAsync<TIn1, TIn2, TOut>(IApiEndpoint<TIn1, TIn2, TOut> endpoint,
            TIn1 urlParameter,
            TIn2 postData);
        Task<TOut> SendAsync<TOut>(IApiEndpoint<HttpRequestMessage, TOut> apiEndpoint,
            HttpRequestMessage request);

        void SetHeaders(Dictionary<string, string> headers);
    }
}