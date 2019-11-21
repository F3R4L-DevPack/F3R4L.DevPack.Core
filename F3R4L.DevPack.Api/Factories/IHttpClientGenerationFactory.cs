using System.Net.Http;

namespace F3R4L.DevPack.Api.Factories
{
    public interface IHttpClientGenerationFactory
    {
        HttpClient CreateClient();
    }
}