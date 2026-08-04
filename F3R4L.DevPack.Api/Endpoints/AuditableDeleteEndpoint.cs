using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class AuditableDeleteEndpoint : ApiEndpoint
    {
        public AuditableDeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
    public abstract class AuditableDeleteEndpoint<T> : ApiEndpoint<T>
    {
        public AuditableDeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
    public abstract class AuditableDeleteEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public AuditableDeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
    public abstract class AuditableDeleteEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public AuditableDeleteEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Delete)
        {
        }
    }
}
