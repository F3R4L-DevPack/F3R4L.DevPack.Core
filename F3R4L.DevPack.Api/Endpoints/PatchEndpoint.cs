using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class PatchEndpoint : ApiEndpoint
    {
        public PatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
    public abstract class PatchEndpoint<T> : ApiEndpoint<T>
    {
        public PatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
    public abstract class PatchEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public PatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
    public abstract class PatchEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public PatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
}
