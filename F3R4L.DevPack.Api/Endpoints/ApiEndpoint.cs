using System;

namespace F3R4L.DevPack.Api.Endpoints
{
    public abstract class ApiEndpoint<TIn, TOut> : IApiEndpoint<TIn, TOut>
    {
        /// <summary>
        /// Endpoint MUST include full formatting for a request
        /// </summary>
        public string Endpoint { get; private set; }

        public ApiEndpoint(string endpoint)
        {
            Endpoint = endpoint;
        }

        public Type GetInputType()
        {
            return typeof(TIn);
        }
        public Type GetOutputType()
        {
            return typeof(TOut);
        }
    }
}
