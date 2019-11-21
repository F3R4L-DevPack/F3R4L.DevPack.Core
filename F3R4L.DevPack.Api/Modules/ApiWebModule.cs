﻿using F3R4L.DevPack.Api.Services;
using F3R4L.DevPack.Api.Wrappers;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.Api.Modules
{
    public class ApiWebModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IJsonSerialisationWrapper>().To<JsonSerialisationWrapper>().InRequestScope();
            Bind<IApiService>().To<ApiService>().InRequestScope();
        }
    }
}
