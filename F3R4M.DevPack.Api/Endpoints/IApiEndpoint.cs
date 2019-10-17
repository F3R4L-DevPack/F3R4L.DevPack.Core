using System;

namespace F3R4M.DevPack.Api.Endpoints
{
    public interface IApiEndpoint<T>
    {
        Enum Application { get; }
        string Endpoint { get; }
    }
}