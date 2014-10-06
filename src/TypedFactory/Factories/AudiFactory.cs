using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypedFactory.Models;
using TypedFactory.Models.Dtos;

namespace TypedFactory.Factories
{
    public class AudiFactory : ICarFactory<Audi>
    {
        public Audi Create(CarDto dto)
        {
            return new Audi
            {
                ModelName = dto.ModelName,
                OwnerName = dto.OwnerName
            };
        }
    }
}
