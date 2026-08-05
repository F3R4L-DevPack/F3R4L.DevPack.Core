using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Exceptions;
using F3R4L.DevPack.Api.Models;
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

        Task<AuditContainer> DeleteAsync(AuditableDeleteEndpoint endpoint);
        Task DeleteAsync(DeleteEndpoint endpoint);
        Task<AuditContainer<T>> DeleteAsync<T>(AuditableDeleteEndpoint<T> endpoint, T request, string contentType = "application/json");
        Task DeleteAsync<T>(DeleteEndpoint<T> endpoint, T request, string contentType = "application/json");
        Task<AuditContainer<TIn, TOut>> GetAsync<TIn, TOut>(AuditableGetEndpoint<TIn, TOut> endpoint, Dictionary<string, object> requestParameters) where TIn : IDictionary<string, object>;
        Task<AuditContainer<TIn, TOut>> GetAsync<TIn, TOut>(AuditableGetEndpoint<TIn, TOut> endpoint, TIn request) where TIn : IConvertible;
        Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, Dictionary<string, object> requestParameters) where TIn : IDictionary<string, object>;
        Task<TOut> GetAsync<TIn, TOut>(GetEndpoint<TIn, TOut> endpoint, TIn request) where TIn : IConvertible;
        Task<AuditContainer<TIn1, TIn2, TOut>> GetAsync<TIn1, TIn2, TOut>(AuditableGetEndpoint<TIn1, TIn2, TOut> endpoint, TIn1 request, Dictionary<string, object> requestParameters)
            where TIn1 : IConvertible
            where TIn2 : IDictionary<string, object>;
        Task<TOut> GetAsync<TIn1, TIn2, TOut>(GetEndpoint<TIn1, TIn2, TOut> endpoint, TIn1 request, Dictionary<string, object> requestParameters)
            where TIn1 : IConvertible
            where TIn2 : IDictionary<string, object>;
        Task<AuditContainer<TOut>> GetAsync<TOut>(AuditableGetEndpoint<TOut> endpoint);
        Task<TOut> GetAsync<TOut>(GetEndpoint<TOut> endpoint);
        Task<AuditContainer<TIn, TOut>> PatchAsync<TIn, TOut>(AuditablePatchEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task<TOut> PatchAsync<TIn, TOut>(PatchEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task<AuditContainer<TIn>> PatchAsync<TIn>(AuditablePatchEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task PatchAsync<TIn>(PatchEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task<AuditContainer<TIn, TOut>> PostAsync<TIn, TOut>(AuditablePostEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task<TOut> PostAsync<TIn, TOut>(PostEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task<AuditContainer<TIn>> PostAsync<TIn>(AuditablePostEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task PostAsync<TIn>(PostEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task<AuditContainer<TIn, TOut>> PutAsync<TIn, TOut>(AuditablePutEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task<TOut> PutAsync<TIn, TOut>(PutEndpoint<TIn, TOut> endpoint, TIn requestObject, string contentType = "application/json") where TIn : class;
        Task<AuditContainer<TIn>> PutAsync<TIn>(AuditablePutEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task PutAsync<TIn>(PutEndpoint<TIn> endpoint, TIn request, string contentType = "application/json");
        Task<TOut> SendAsync<TOut>(HttpRequestMessage request);
        void SetAuthorisationToken(string token, string tokenType = "Bearer");
        void SetHeaders(Dictionary<string, string> headers);
    }
}