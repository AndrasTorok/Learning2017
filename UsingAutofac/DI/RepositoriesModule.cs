using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAutofac.Concrete;

namespace UsingAutofac.DI
{
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(RepositoryBase<>)).As(typeof(Abstract.IRepository<>));
        }
    }
}
