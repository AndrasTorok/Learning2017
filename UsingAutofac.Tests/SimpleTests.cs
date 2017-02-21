using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsingAutofac.DI;
using UsingAutofac.Abstract;

namespace UsingAutofac.Tests
{
    [TestClass]
    public class SimpleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var container = new DIContainer();
            using(var scope = container.Scope)
            {
                var person = container.Get<IPerson>(scope);
                var organization = container.Get<IOrganization>(scope);
                var organizationRepository = container.Get<IRepository<IOrganization>>(scope);

                var organization1 = organizationRepository.GetById(1);
            }            
        }
    }
}
