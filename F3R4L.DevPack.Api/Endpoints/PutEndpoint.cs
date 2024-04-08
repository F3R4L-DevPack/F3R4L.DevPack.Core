using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class PutEndpoint : ApiEndpoint
    {
        public PutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
    public abstract class PutEndpoint<T> : ApiEndpoint<T>
    {
        public PutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
    public abstract class PutEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public PutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
    public abstract class PutEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public PutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
}
