using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public interface IApiService
    {
        HttpRequestHeaders Headers { get; }

        ApiCallException CreateException(string uri, string method, HttpStatusCode statusCode, string reason);
        Task DeleteAsync(DeleteEndpoint endpoint);
        Task DeleteAsync<T>(DeleteEndpoint<T> endpoint, T request, string contentType = "application/json");
        Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, Dictionary<string, object> requestParameters) where TIn : IDictionary<string, object>;
        Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, TIn request) where TIn : IConvertible;
        Task<TOut> GetAsync<TIn1, TIn2, TOut>(GetEndpoint<TIn1, TIn2, TOut> endpoint, TIn1 request, Dictionary<string, object> requestParameters)
            where TIn1 : IConvertible
            where TIn2 : IDictionary<string, object>;
        Task<TOut> GetAsync<TOut>(GetEndpoint<TOut> endpoint);
        Task<TOut> PatchAsync<TIn, TOut>(PatchEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task PatchAsync<TIn>(PatchEndpoint<TIn> endpoint);
        Task PatchAsync<TIn>(PatchEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task PostAsync(PostEndpoint endpoint);
        Task<TOut> PostAsync<TIn, TOut>(PostEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task PostAsync<TIn>(PostEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task<TOut> PutAsync<TIn, TOut>(PutEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task PutAsync<TIn>(PutEndpoint<TIn> endpoint);
        Task PutAsync<TIn>(PutEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task<TOut> SendAsync<TOut>(HttpRequestMessage request);
        void SetAuthorisationToken(string token);
        void SetHeaders(Dictionary<string, string> headers);
    }
}