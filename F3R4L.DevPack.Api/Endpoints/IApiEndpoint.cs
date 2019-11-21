using System;

namespace F3R4L.DevPack.Api.Endpoints
{
    public interface IApiEndpoint<TIn, TOut>
    {
        /// <summary>
        /// Endpoint MUST include full formatting for a request
        /// </summary>
        string Endpoint { get; }
        Type GetInputType();
        Type GetOutputType();
    }
}