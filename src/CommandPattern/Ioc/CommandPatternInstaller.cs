using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TypedFactory.Providers;
using Castle.Facilities.TypedFactory;
using CommandPattern.Handlers;
using CommandPattern.Services;

namespace TypedFactory.Ioc
{
    public class CommandPatternInstaller : IWindsorInstaller
    {
        public void Install(
            IWindsorContainer container, 
            IConfigurationStore store
            )
        {
            container.Register(
                Classes
                    .FromThisAssembly()
                    .BasedOn(typeof(ICommandHandler<>))
                    .WithServiceAllInterfaces()
                    .LifestyleTransient(),

                Component
                    .For<IHandlerProvider>()
                    .AsFactory(),

                Component
                    .For<CommandProcessor>()
                );
        }
    }
}
