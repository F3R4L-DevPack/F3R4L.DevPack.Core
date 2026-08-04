using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class AuditablePutEndpoint : ApiEndpoint
    {
        public AuditablePutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
    public abstract class AuditablePutEndpoint<T> : ApiEndpoint<T>
    {
        public AuditablePutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
    public abstract class AuditablePutEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public AuditablePutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
    public abstract class AuditablePutEndpoint<TIn1, TIn2, TOut> : ApiEndpoint<TIn1, TIn2, TOut>
    {
        public AuditablePutEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Put)
        {
        }
    }
}
