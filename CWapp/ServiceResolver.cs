using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWapp
{

    public class ServiceResolver
    {
        private static WindsorContainer container;
        private static IServiceProvider serviceProvider;

        public ServiceResolver(IServiceCollection services)
        {
            container = new WindsorContainer();
            //Register your components in container

            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            //then
            serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(container, services);
        }

        public IServiceProvider GetServiceProvider()
        {
            return serviceProvider;
        }
    }

}
