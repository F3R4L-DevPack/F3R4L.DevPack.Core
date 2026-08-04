using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class AuditablePostEndpoint : ApiEndpoint
    {
        public AuditablePostEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Post)
        {
        }
    }
    public abstract class AuditablePostEndpoint<T> : ApiEndpoint<T>
    {
        public AuditablePostEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Post)
        {
        }
    }
    public abstract class AuditablePostEndpoint<TIn, TOut> : ApiEndpoint<TIn, TOut>
    {
        public AuditablePostEndpoint(string hostName, string endpoint)
            : base(hostName, endpoint, HttpMethod.Post)
        {
        }
    }
}
