using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using TypedFactory.Ioc;
using TypedFactory.Models.Dtos;
using TypedFactory.Services;
using Xunit;
using FluentAssertions;
using TypedFactory.Models;

namespace TypedFactory.Tests.Services
{
    public class CarBuilderTests
    {
        private readonly IWindsorContainer container;
        private readonly CarBuilder sut;
        
        public CarBuilderTests()
        {
            container = TypedFactoryBootstrapper.Bootstrap();
            sut = container.Resolve<CarBuilder>();
        }

        [Fact]
        public void Should_Build_A_Fiat()
        {
            var data = new CarDto()
            {
                OwnerName = "Neil",
                ModelName = "500",
                CarType = CarType.Fiat
            };

            var result = sut.Build(data);

            result.Should().BeOfType<Fiat>();
            result.ModelName.Should().Be("500");
            result.OwnerName.Should().Be("Neil");
        }

        [Fact]
        public void Should_Build_A_Ferrari()
        {
            var data = new CarDto()
            {
                OwnerName = "Neil",
                ModelName = "Enzo",
                CarType = CarType.Ferrari
            };

            var result = sut.Build(data);

            result.Should().BeOfType<Ferrari>();
            result.ModelName.Should().Be("Enzo");
            result.OwnerName.Should().Be("Neil");
        }

        [Fact]
        public void Should_Build_A_Audi()
        {
            var data = new CarDto()
            {
                OwnerName = "Neil",
                ModelName = "A8",
                CarType = CarType.Audi
            };

            var result = sut.Build(data);

            result.Should().BeOfType<Audi>();
            result.ModelName.Should().Be("A8");
            result.OwnerName.Should().Be("Neil");
        }
    }
}
