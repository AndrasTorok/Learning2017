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
    public class DIContainer
    {
        public T Get<T>()
        {
            return Container.Resolve<T>();
        }

        public ILifetimeScope Scope
        {
            get
            {
                return Container.BeginLifetimeScope();
            }
        }

        public T Get<T>(ILifetimeScope scope)
        {
            return scope.Resolve<T>();
        }

        private IContainer Container
        {
            get
            {
                if (_container == null)
                {
                    lock (_syncLock)
                    {
                        if (_container == null)
                        {
                            BuildContainer();
                        }
                    }
                }

                return _container;
            }
        }

        private static IContainer _container;
        private static readonly object _syncLock = new object();

        private static void BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new EntitiesModule());
            builder.RegisterModule(new RepositoriesModule());
            RegisterTypes(builder);

            _container = builder.Build();
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {            
            
        }
    }
}
