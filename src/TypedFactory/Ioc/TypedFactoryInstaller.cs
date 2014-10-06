using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TypedFactory.Factories;
using TypedFactory.Providers;
using Castle.Facilities.TypedFactory;
using TypedFactory.Services;

namespace TypedFactory.Ioc
{
    public class TypedFactoryInstaller : IWindsorInstaller
    {
        public void Install(
            IWindsorContainer container, 
            IConfigurationStore store
            )
        {
            container.Register(
                Classes
                    .FromThisAssembly()
                    .BasedOn(typeof(ICarFactory<>))
                    .WithServiceAllInterfaces()
                    .LifestyleTransient(),

                Component
                    .For<ICarFactoryProvider>()
                    .AsFactory(),

                Component
                    .For<CarBuilder>()
                );
        }
    }
}
