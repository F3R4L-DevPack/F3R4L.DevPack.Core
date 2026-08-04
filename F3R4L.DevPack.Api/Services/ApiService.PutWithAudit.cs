using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task<RequestOnlyAuditContainer<TIn>> PutAsync<TIn>(AuditablePatchEndpoint<TIn> endpoint, TIn request,
            string contentType = "application/json")
        {
            var result = new RequestOnlyAuditContainer<TIn>()
            {
                Url = endpoint.Address
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            try
            {
                var requestString = _jsonSerialiser.Serialise<TIn>(request);
                httpResponse = await _httpClient.PutAsync(endpoint.Address,
                    new StringContent(requestString, Encoding.UTF8,
                    contentType));
                var responseString = await httpResponse.Content.ReadAsStringAsync();
                result.Request = new ObjectContainer<TIn>()
                {
                    Json = requestString,
                    Object = _jsonSerialiser.Deserialise<TIn>(responseString)
                };
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.ResponseMessage = await httpResponse.Content.ReadAsStringAsync();
            }
            finally
            {
                result.StatusCode = httpResponse.StatusCode;
            }

            return result;
        }

        public async Task<AuditContainer<TIn, TOut>> PutAsync<TIn, TOut>(AuditablePatchEndpoint<TIn, TOut> endpoint, TIn requestObject,
            string contentType = "application/json")
            where TIn : class
        {
            var result = new AuditContainer<TIn, TOut>()
            {
                Url = endpoint.Address
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            try
            {
                var requestString = _jsonSerialiser.Serialise<TIn>(requestObject);
                httpResponse = await _httpClient.PutAsync(endpoint.Address,
                    new StringContent(requestString, Encoding.UTF8,
                    contentType));
                var responseString = await httpResponse.Content.ReadAsStringAsync();
                result.Request = new ObjectContainer<TIn>()
                {
                    Json = requestString,
                    Object = _jsonSerialiser.Deserialise<TIn>(requestString)
                };
                result.Response = new ObjectContainer<TOut>()
                {
                    Json = responseString,
                    Object = _jsonSerialiser.Deserialise<TOut>(responseString)
                };
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.ResponseMessage = await httpResponse.Content.ReadAsStringAsync();
            }
            finally
            {
                result.StatusCode = httpResponse.StatusCode;
            }

            return result;
        }
    }
