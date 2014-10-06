using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypedFactory.Models;
using TypedFactory.Models.Dtos;
using TypedFactory.Providers;

namespace TypedFactory.Services
{
    public class CarBuilder
    {
        private readonly ICarFactoryProvider carFactoryProvider;
        private readonly Dictionary<CarType, Func<CarDto, ICar>> carMap;
        
        public CarBuilder(
            ICarFactoryProvider carFactoryProvider
            )
        {
            this.carFactoryProvider = carFactoryProvider;

            carMap = new Dictionary<CarType, Func<CarDto, ICar>>
            {
                { CarType.Audi, (dto) => BuildCar<Audi>(dto) },
                { CarType.Ferrari, (dto) => BuildCar<Ferrari>(dto) },
                { CarType.Fiat, (dto) => BuildCar<Fiat>(dto) }
            };
        }

        public ICar Build(
            CarDto carDto
            )
        {
            if (carMap.ContainsKey(carDto.CarType) == false)
            {
                throw new ArgumentOutOfRangeException(
                    String.Format("unknown car type {0}", carDto.CarType.ToString())
                    );
            }

            return carMap[carDto.CarType].Invoke(carDto);
        }

        private TCar BuildCar<TCar>(CarDto dto)
            where TCar : class, ICar
        {
            var factory = carFactoryProvider.Create<TCar>();
            return factory.Create(dto);
        }
    }
}
