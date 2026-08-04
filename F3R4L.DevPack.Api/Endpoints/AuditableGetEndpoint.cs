using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class AuditableGetEndpoint : ApiEndpoint
    {
        public AuditableGetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
    public abstract class AuditableGetEndpoint<T> : ApiEndpoint<T>
    {
        public AuditableGetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
    public abstract class AuditableGetEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public AuditableGetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
    public abstract class AuditableGetEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public AuditableGetEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Get)
        {
        }
    }
}
