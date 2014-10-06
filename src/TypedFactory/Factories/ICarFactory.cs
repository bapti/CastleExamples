using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypedFactory.Models;
using TypedFactory.Models.Dtos;

namespace TypedFactory.Factories
{
    public interface ICarFactory<out TCar>
        where TCar : class, ICar
    {
        TCar Create(CarDto dto);
    }
}
