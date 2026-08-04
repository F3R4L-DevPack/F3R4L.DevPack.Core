using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class AuditablePatchEndpoint : ApiEndpoint
    {
        public AuditablePatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
    public abstract class AuditablePatchEndpoint<T> : ApiEndpoint<T>
    {
        public AuditablePatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
    public abstract class AuditablePatchEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public AuditablePatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
    public abstract class AuditablePatchEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public AuditablePatchEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Patch)
        {
        }
    }
}
