using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4M.DevPack.Api.Endpoints
{
    public class ApiEndpoint<T> : IApiEndpoint<T>
    {
        public string Endpoint { get; private set; }
        public Enum Application { get; private set; }

        public ApiEndpoint(string endpoint, Enum application)
        {
            Endpoint = endpoint;
            Application = application;
        }

        public Type GetEndpointType()
        {
            return typeof(T);
        }
    }
}
