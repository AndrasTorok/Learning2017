using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsingAutofac.DI;
using Autofac;

namespace UsingAutofc.Web.Tests.Base
{
    [TestClass]
    public class TestBase
    {
        private readonly DIContainer _container;

        public TestBase()
        {
            _container = new DIContainer();
        }

        protected ILifetimeScope Scope { get; private set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Scope = _container.Scope;
        }
    }
}
