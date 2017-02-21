using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using UsingAutofac.DI;
using UsingAutofc.Web.Controllers;
using System.Reflection;
using Autofac.Integration.WebApi;
using System.Web.Http;

[assembly: OwinStartup(typeof(UsingAutofc.Web.Startup))]

namespace UsingAutofc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterModule<EntitiesModule>();
            builder.RegisterModule<RepositoriesModule>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();

            ConfigureAuth(app);
        }
    }
}
