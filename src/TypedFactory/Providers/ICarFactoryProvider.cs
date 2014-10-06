using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypedFactory.Factories;
using TypedFactory.Models;

namespace TypedFactory.Providers
{
    public interface ICarFactoryProvider : IDisposable
    {
        ICarFactory<TCar> Create<TCar>()
            where TCar : class, ICar;

        void Release<TCar>(ICarFactory<TCar> factory)
            where TCar : class, ICar;
    }
}
