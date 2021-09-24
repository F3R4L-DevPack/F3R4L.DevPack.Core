using F3R4L.DevPack.Api.Factories;
using F3R4L.DevPack.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Options;

namespace F3R4L.DevPack.Api.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddF3R4LApiBindings(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IHttpContextAccessor), typeof(HttpContextAccessor));
            serviceCollection.AddScoped(typeof(IHttpClientGenerationFactory), typeof(HttpClientGenerationFactory));
            serviceCollection.AddScoped(typeof(IOptionsMonitor<HttpClientFactoryOptions>), typeof(OptionsMonitor<HttpClientFactoryOptions>));
            serviceCollection.AddScoped(typeof(IApiService), typeof(ApiService));
        }
    }
}