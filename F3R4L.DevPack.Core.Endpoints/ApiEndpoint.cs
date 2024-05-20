using System;
using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class ApiEndpoint : IApiEndpoint
    {
        public string HostName { get; private set; }
        public string Endpoint { get; private set; }
        public HttpMethod HttpMethod { get; private set; }

        public string Address
        {
            get
            {
                return string.Concat(HostName, Endpoint);
            }
        }

        public ApiEndpoint(string endpoint, HttpMethod httpMethod)
        {
            var url = new Uri(endpoint);
            HostName = url.Host;
            Endpoint = url.AbsolutePath;
            HttpMethod = httpMethod;
        }

        public ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod)
        {
            HostName = hostName;
            Endpoint = endpoint;
            HttpMethod = httpMethod;
        }
    }

    public abstract class ApiEndpoint<T> : ApiEndpoint, IApiEndpoint<T>
    {
        public ApiEndpoint(string hostName, HttpMethod httpMethod) : base(hostName, httpMethod)
        {
        }
        public ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod) : base(hostName, endpoint, httpMethod)
        {
        }
    }

    public abstract class ApiEndpoint<TIn, TOut> : ApiEndpoint, IApiEndpoint<TIn, TOut>
    {
        public ApiEndpoint(string hostName, HttpMethod httpMethod) : base(hostName, httpMethod)
        {
        }
        public ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod) : base(hostName, endpoint, httpMethod)
        {
        }
    }

    public abstract class ApiEndpoint<TIn1, TIn2, TOut> : ApiEndpoint, IApiEndpoint<TIn1, TIn2, TOut>
    {
        public ApiEndpoint(string hostName, HttpMethod httpMethod) : base(hostName, httpMethod)
        {
        }
        public ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod) : base(hostName, endpoint, httpMethod)
        {
        }
    }
}
