using F3R4L.DevPack.SSO.Web;
using Ninject.Modules;

namespace F3R4L.DevPack.SSO.Ninject
{
    public class SingleSignOnModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISingleSignOnService>().To<SingleSignOnService>().InSingletonScope();
        }
    }
}