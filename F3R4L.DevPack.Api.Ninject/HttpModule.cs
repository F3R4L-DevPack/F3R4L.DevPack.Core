using F3R4L.DevPack.Api.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Options;
using Ninject.Modules;
using Ninject.Web.Common;

namespace F3R4L.DevPack.Api.Ninject
{
    public class HttpModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IHttpContextAccessor>().To<HttpContextAccessor>().InSingletonScope();
            Bind<IHttpClientGenerationFactory>().To<HttpClientGenerationFactory>().InRequestScope();
            Bind<IOptionsMonitor<HttpClientFactoryOptions>>().To<OptionsMonitor<HttpClientFactoryOptions>>().InRequestScope();
        }
    }
}