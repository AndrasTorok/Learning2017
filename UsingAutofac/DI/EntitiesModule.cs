using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAutofac.Abstract;
using UsingAutofac.Concrete;

namespace UsingAutofac.DI
{
    public class EntitiesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Person>().As<IPerson>();
            builder.RegisterType<Organization>().As<IOrganization>();
        }
    }
}
