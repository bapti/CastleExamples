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

namespace CommandPattern.Tests
{
    public class CommandPatternTests
    {
        private readonly IWindsorContainer container;
        private readonly CommandProcessor sut;

        public CommandPatternTests()
        {
            container = CommandPatternBootstrapper.Bootstrap();
            sut = container.Resolve<CommandProcessor>();
        }

        [Fact]
        public void Should_Run_Accelerate_Through_Logging_Timing_Then_Accelerate()
        {
            var data = new AccelerateCommand();

            sut.ProcessCommand<AccelerateCommand>(data);

            data.Log[0].Should().Be("logger");
            data.Log[1].Should().Be("timing");
            data.Log[2].Should().Be("accelerate");
        }
    }
}
