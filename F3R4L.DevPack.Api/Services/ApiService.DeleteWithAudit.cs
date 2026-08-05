using F3R4L.DevPack.Api.Endpoints;
using F3R4L.DevPack.Api.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService
    {
        public async Task<AuditContainer> DeleteAsync(AuditableDeleteEndpoint endpoint)
        {
            var result = new AuditContainer()
            {
                Url = endpoint.Address
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            try
            {
                httpResponse = await _httpClient.DeleteAsync(endpoint.Address);
            }
            catch(Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            finally
            {
                result.StatusCode = httpResponse.StatusCode;
                result.ResponseMessage = await httpResponse.Content.ReadAsStringAsync();
            }
            return result;
        }

        public async Task<AuditContainer<T>> DeleteAsync<T>(AuditableDeleteEndpoint<T> endpoint, T request,
            string contentType = "application/json")
        {
            var result = new AuditContainer<T>()
            {
                Url = endpoint.Address,
                Request = new ObjectContainer<T>()
                {
                    Object = request,
                    Json = _jsonSerialiser.Serialise(request)
                }
            };
            var httpResponse = default(System.Net.Http.HttpResponseMessage);

            var requestMsg = new HttpRequestMessage()
            {
                Content = new StringContent(result.Request.Json,
                    Encoding.UTF8, contentType),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(endpoint.Address)
            };

            try 
            {                 
                httpResponse = await _httpClient.SendAsync(requestMsg);
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            finally
            {
                result.StatusCode = httpResponse.StatusCode;
                result.ResponseMessage = await httpResponse.Content.ReadAsStringAsync();
            }

            return result;
        }
    }
}
