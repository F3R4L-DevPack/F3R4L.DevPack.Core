using System;
using System.Net.Http;
using System.Net;

namespace F3R4L.DevPack.Api.Exceptions
{
    public class ApiCallException : Exception
    {
        private const string _messageFormat = "The {0} call to {1} failed with status code {2}. Please check the inner exception for details.";

        /// <summary>
        /// An exception throw when an ApiService call fails
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="httpMethod"></param>
        /// <param name="statusCode"></param>
        /// <param name="message"></param>
        public ApiCallException(string uri, string httpMethod, HttpStatusCode statusCode, string message)
            : base(string.Format(_messageFormat, Enum.GetName(typeof(HttpMethod), httpMethod), uri,
                statusCode.ToString()), new Exception(message))
        {
            Uri = uri;
            HttpMethod = httpMethod;
            StatusCode = (int)statusCode;
        }

        public string Uri { get; private set; }
        public string HttpMethod { get; private set; }
        public int StatusCode { get; private set; }
    }
}
