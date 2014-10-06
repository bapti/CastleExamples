using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypedFactory.Models;
using TypedFactory.Models.Dtos;

namespace TypedFactory.Factories
{
    public class FerarriFactory : ICarFactory<Ferrari>
    {
        public Ferrari Create(CarDto dto)
        {
            return new Ferrari
            {
                ModelName = dto.ModelName,
                OwnerName = dto.OwnerName
            };
        }
    }
}
