using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypedFactory.Factories;
using TypedFactory.Models.Dtos;

namespace TypedFactory.Models
{
    public class FiatFactory : ICarFactory<Fiat>
    {
        public Fiat Create(CarDto dto)
        {
            return new Fiat
            {
                ModelName = dto.ModelName,
                OwnerName = dto.OwnerName
            };
        }
    }
}
