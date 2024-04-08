using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class GetEndpoint : ApiEndpoint
    {
        public GetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
    public abstract class GetEndpoint<T> : ApiEndpoint<T>
    {
        public GetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
    public abstract class GetEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public GetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
    public abstract class GetEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public GetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
}
