using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace F3R4L.DevPack.Api.Models
{
    public class AuditContainer
    {
        public string Url { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ResponseMessage { get; set; }
    }

    public class AuditContainer<T> : AuditContainer
    {
        public ObjectContainer<T> Request { get; set; }
        public ObjectContainer<T> Response { get; set; }
    }

    public class AuditContainer<TIn, TOut> : AuditContainer
    {
        public ObjectContainer<TIn> Request { get; set; }
        public ObjectContainer<TOut> Response { get; set; }
    }

    [Obsolete("This class is deprecated. Use AuditContainer<TIn, TOut> instead.")]
    public class AuditContainer<TIn1, TIn2, TOut> : AuditContainer
    {
        public ObjectContainer<TIn1> Request1 { get; set; }
        public ObjectContainer<TIn2> Request2 { get; set; }
        public ObjectContainer<TOut> Response { get; set; }
    }

    public class ObjectContainer<T>
    {
        public T Object { get; set; }
        public string Json { get; set; }
    }
}
