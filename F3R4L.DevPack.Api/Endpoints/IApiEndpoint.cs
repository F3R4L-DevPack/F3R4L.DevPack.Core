using System;

namespace F3R4L.DevPack.Api.Endpoints
{
    public interface IApiEndpoint<TIn, TOut>
    {
        /// <summary>
        /// Endpoint MUST include full formatting for a request
        /// </summary>
        string Endpoint { get; }
        string AddParameters(object[] args);
    }

    public interface IApiEndpoint<TIn1, TIn2, TOut>
    {
        /// <summary>
        /// Endpoint MUST include full formatting for a request
        /// </summary>
        string Endpoint { get; }
        string AddParameters(object[] args);
    }
}