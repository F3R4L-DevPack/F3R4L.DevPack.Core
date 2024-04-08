using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class PostEndpoint : ApiEndpoint
    {
        public PostEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Post)
        {
        }
    }
    public abstract class PostEndpoint<T> : ApiEndpoint<T>
    {
        public PostEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Post)
        {
        }
    }
    public abstract class PostEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public PostEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Post)
        {
        }
    }
    public abstract class PostEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public PostEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Post)
        {
        }
    }
}
