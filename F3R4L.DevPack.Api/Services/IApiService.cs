using System;
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

        Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, Dictionary<string, object> requestParameters) where TIn : IDictionary<string, object>;
        Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, TIn request) where TIn : IConvertible;
        Task<TOut> GetAsync<TIn1, TIn2, TOut>(GetEndpoint<TIn1, TIn2, TOut> endpoint, TIn1 request, Dictionary<string, object> requestParameters)
            where TIn1 : IConvertible
            where TIn2 : IDictionary<string, object>;
        Task<TOut> GetAsync<TOut>(GetEndpoint<TOut> endpoint);
        Task<TOut> PostAsync<TIn, TOut>(PostEndpoint<TIn, TOut> endpoint, TIn requestObject) where TIn : class;
        Task PostAsync<TIn>(PostEndpoint<TIn> endpoint, TIn request);
        Task PostAsync(PostEndpoint endpoint);
        void SetAuthorisationToken(string token);
        void SetHeaders(Dictionary<string, string> headers);
        Task PutAsync<TIn>(PutEndpoint<TIn> endpoint, TIn request);
        Task<TOut> PutAsync<TIn, TOut>(PutEndpoint<TIn, TOut> endpoint, TIn requestObject)
            where TIn : class;
        Task DeleteAsync(DeleteEndpoint endpoint);
        Task DeleteAsync<T>(DeleteEndpoint<T> endpoint, T request);
        Task PutAsync<TIn>(PutEndpoint<TIn> endpoint);
        Task PatchAsync<TIn>(PatchEndpoint<TIn> endpoint);
        Task PatchAsync<TIn>(PatchEndpoint<TIn> endpoint, TIn request);
        Task<TOut> PatchAsync<TIn, TOut>(PatchEndpoint<TIn, TOut> endpoint, TIn requestObject)
            where TIn : class;
        Task<TOut> SendAsync<TOut>(HttpRequestMessage request);
    }
}