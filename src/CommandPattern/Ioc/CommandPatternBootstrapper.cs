using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Facilities.TypedFactory;
using Castle.Windsor;

namespace TypedFactory.Ioc
{
    public static class CommandPatternBootstrapper
    {
        public static IWindsorContainer Bootstrap()
        {
            var container = new WindsorContainer();

            container.AddFacility<TypedFactoryFacility>();

            container.Install(
                new CommandPatternInstaller()
                );

            return container;
        }
    }
}
