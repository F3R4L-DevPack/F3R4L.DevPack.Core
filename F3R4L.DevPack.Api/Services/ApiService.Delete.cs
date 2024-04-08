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
        public async Task DeleteAsync(DeleteEndpoint endpoint)
        {
            await _httpClient.DeleteAsync(endpoint.Address);
        }

        public async Task DeleteAsync<T>(DeleteEndpoint<T> endpoint, T request)
        {
            var requestMsg = new HttpRequestMessage()
            {
                Content = new StringContent(_jsonSerialiser.Serialise(request),
                    Encoding.UTF8, "application/json"),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(endpoint.Address)
            };
            var result = await _httpClient.SendAsync(requestMsg);
            if (!result.IsSuccessStatusCode)
            {
                throw CreateException(endpoint.Address, endpoint.HttpMethod.ToString(),
                    result.StatusCode, result.ReasonPhrase ?? _noReasonPhrase);
            }
        }
    }
}
