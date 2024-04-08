using F3R4L.DevPack.Api.Exceptions;
using F3R4L.DevPack.Api.Factories;
using F3R4L.DevPack.Api.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace F3R4L.DevPack.Api.Services
{
    public partial class ApiService : IApiService
    {
        private readonly IJsonSerialisationWrapper _jsonSerialiser;

        private readonly HttpClient _httpClient;

        private const string _authorisation = "authorization";

        private const string _noReasonPhrase = "No reason was provided.";

        public HttpRequestHeaders Headers
        {
            get
            {
                return _httpClient.DefaultRequestHeaders;
            }
        }

        public ApiService(IHttpClientFactory httpClientFactory, IJsonSerialisationWrapper jsonSerialiser)
        {
            _jsonSerialiser = jsonSerialiser;

            _httpClient = httpClientFactory.CreateClient();
        }

        public void SetAuthorisationToken(string token)
        {
            if (Headers.Contains(_authorisation))
            {
                Headers.Remove(_authorisation);
            }
            Headers.Add(_authorisation, string.Concat("Bearer ", token));
        }

        public void SetHeaders(Dictionary<string, string> headers)
        {
            Headers.Clear();
            headers.ToList().ForEach((header) =>
                Headers.Add(header.Key, header.Value));
        }

        public ApiCallException CreateException(string uri, string method, HttpStatusCode statusCode, string reason)
        {
            return new ApiCallException(uri, method, statusCode, reason);
        }
    }
}
