using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Facilities.TypedFactory;
using CommandPattern.Handlers;
using CommandPattern.Services;
using CommandPattern.Infrastructure;

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
                Component
                    .For(typeof(ICommandHandler<>))
                    .ImplementedBy(typeof(LoggingDecorator<>))
                    .LifestyleTransient(),
                
                Component
                    .For(typeof(ICommandHandler<>))
                    .ImplementedBy(typeof(TimingDecorator<>))
                    .LifestyleTransient(),
                
                Classes
                    .FromThisAssembly()
                    .BasedOn(typeof(ICommandHandler<>))
                    .WithServiceBase()
                    .LifestyleTransient(),

                Component
                    .For<ICommandHandlerFactory>()
                    .AsFactory(),

                Component
                    .For<CommandProcessor>()
                );
        }
    }
}
