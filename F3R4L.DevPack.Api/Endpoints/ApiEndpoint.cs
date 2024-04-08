using System;
using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class ApiEndpoint
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

        protected ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod)
        {
            HostName = hostName;
            Endpoint = endpoint;
            HttpMethod = httpMethod;
        }
    }

    public abstract class ApiEndpoint<T> : ApiEndpoint
    {
        protected ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod)
            : base(hostName, endpoint, httpMethod)
        {
        }
    }

    public abstract class ApiEndpoint<TIn, TOut> : ApiEndpoint
    {
        protected ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod)
            : base(hostName, endpoint, httpMethod)
        {
        }
    }

    public abstract class ApiEndpoint<TIn1, TIn2, TOut> : ApiEndpoint
    {
        protected ApiEndpoint(string hostName, string endpoint, HttpMethod httpMethod)
            : base(hostName, endpoint, httpMethod)
        {
        }
    }
}
