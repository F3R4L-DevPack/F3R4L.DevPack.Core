using F3R4L.DevPack.SSO.Web;
using Microsoft.Extensions.DependencyInjection;

namespace F3R4L.DevPack.SSO.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddF3R4LSSOBindings(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(ISingleSignOnService), typeof(SingleSignOnService));
        }
    }
}