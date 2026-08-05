using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Extensions;
using F3R4L.DevPack.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task<AuditContainer<TOut>> GetAsync<TOut>(AuditableGetEndpoint<TOut> endpoint)
        {
            var result = new AuditContainer<TOut>()
            {
                Url = endpoint.Address
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            try
            {
                httpResponse = await _httpClient.GetAsync(endpoint.Address);
                var json = await httpResponse.Content.ReadAsStringAsync();
                result.Response = new ObjectContainer<TOut>()
                {
                    Json = json,
                    Object = _jsonSerialiser.Deserialise<TOut>(json)
                };
            }
            catch(Exception ex)
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

        public async Task<AuditContainer<TIn, TOut>> GetAsync<TIn, TOut>(AuditableGetEndpoint<TIn, TOut> endpoint, TIn request)
            where TIn : IConvertible
        {
            var result = new AuditContainer<TIn, TOut>()
            {
                Url = endpoint.Address
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            try
            {
                httpResponse = await _httpClient.GetAsync(string.Format(endpoint.Address, request.ToString()));
                var json = await httpResponse.Content.ReadAsStringAsync();
                result.Response = new ObjectContainer<TOut>()
                {
                    Json = json,
                    Object = _jsonSerialiser.Deserialise<TOut>(json)
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

        public async Task<AuditContainer<TIn, TOut>> GetAsync<TIn, TOut>(AuditableGetEndpoint<TIn, TOut> endpoint, Dictionary<string, object> requestParameters)
            where TIn : IDictionary<string, object>
        {
            var suffix = requestParameters.ToUrlParameterString();
            var result = new AuditContainer<TIn, TOut>()
            {
                Url = string.Concat(endpoint.Address, "?", suffix)
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            try
            {
                httpResponse = await _httpClient.GetAsync(endpoint.Address);
                var json = await httpResponse.Content.ReadAsStringAsync();
                result.Response = new ObjectContainer<TOut>()
                {
                    Json = json,
                    Object = _jsonSerialiser.Deserialise<TOut>(json)
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

        public async Task<AuditContainer<TIn1, TIn2, TOut>> GetAsync<TIn1, TIn2, TOut>(AuditableGetEndpoint<TIn1, TIn2, TOut> endpoint, TIn1 request, Dictionary<string, object> requestParameters)
            where TIn1 : IConvertible
            where TIn2 : IDictionary<string, object>
        {
            var suffix = requestParameters.ToUrlParameterString();
            var result = new AuditContainer<TIn1, TIn2, TOut>()
            {
                Url = string.Concat(string.Format(endpoint.Address, request.ToString()), "?", suffix)
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            try
            {
                httpResponse = await _httpClient.GetAsync(endpoint.Address);
                var json = await httpResponse.Content.ReadAsStringAsync();
                result.Response = new ObjectContainer<TOut>()
                {
                    Json = json,
                    Object = _jsonSerialiser.Deserialise<TOut>(json)
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
}
