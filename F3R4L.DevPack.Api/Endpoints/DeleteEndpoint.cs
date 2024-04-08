using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class DeleteEndpoint : ApiEndpoint
    {
        public DeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
    public abstract class DeleteEndpoint<T> : ApiEndpoint<T>
    {
        public DeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
    public abstract class DeleteEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public DeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
    public abstract class DeleteEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public DeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
}
