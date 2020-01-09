﻿using System;

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
    }

    public abstract class ApiEndpoint<TIn1, TIn2, TOut> : IApiEndpoint<TIn1, TIn2, TOut>
    {
        /// <summary>
        /// Endpoint MUST include full formatting for a request
        /// </summary>
        public string Endpoint { get; private set; }

        public ApiEndpoint(string endpoint)
        {
            Endpoint = endpoint;
        }
    }
}
