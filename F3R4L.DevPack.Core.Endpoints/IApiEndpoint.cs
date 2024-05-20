using System.Net.Http;

namespace F3R4L.DevPack.Api.Endpoints
{
    public interface IApiEndpoint
    {
        string Address { get; }
        string Endpoint { get; }
        string HostName { get; }
        HttpMethod HttpMethod { get; }
    }

    public interface IApiEndpoint<T>
    {
        string Address { get; }
        string Endpoint { get; }
        string HostName { get; }
        HttpMethod HttpMethod { get; }
    }

    public interface IApiEndpoint<TIn, TOut>
    {
        string Address { get; }
        string Endpoint { get; }
        string HostName { get; }
        HttpMethod HttpMethod { get; }
    }

    public interface IApiEndpoint<TInTIn1, TIn2, TOut>
    {
        string Address { get; }
        string Endpoint { get; }
        string HostName { get; }
        HttpMethod HttpMethod { get; }
    }
}