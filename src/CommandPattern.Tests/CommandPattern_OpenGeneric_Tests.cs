using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using CommandPattern.Commands.Accelerate;
using CommandPattern.Infrastructure;
using TypedFactory.Ioc;
using Xunit;
using FluentAssertions;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using CommandPattern.Handlers;

namespace CommandPattern.Tests
{
    public class CommandPattern_OpenGeneric_Tests
    {
        private readonly CommandProcessor sut;

        public CommandPattern_OpenGeneric_Tests()
        {
            var container = new WindsorContainer();
            container.AddFacility<TypedFactoryFacility>();

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
                    .WithServiceFromInterface()
                    .LifestyleTransient(),

                //Component
                //    .For(typeof(ICommandHandler<AccelerateCommand>))
                //    .ImplementedBy(typeof(AccelerateCommandHandler))
                //    .LifestyleTransient(),   

                Component.For<ICommandHandlerFactory>().AsFactory(),
                Component.For<IMetrics>().ImplementedBy<Metrics>(),
                Component.For<ILogger>().ImplementedBy<Logger>(),
                Component.For<CommandProcessor>()
                );

            sut = container.Resolve<CommandProcessor>();
        }

        [Fact]
        public void Should_Run_Accelerate_Through_Logging_Timing_Then_Accelerate()
        {
            var data = new AccelerateCommand();

            sut.ProcessCommand<AccelerateCommand>(data);

            data.Log[0].Should().Be("logging");
            data.Log[1].Should().Be("timing");
            data.Log[2].Should().Be("accelerate");
        }
    }
}
