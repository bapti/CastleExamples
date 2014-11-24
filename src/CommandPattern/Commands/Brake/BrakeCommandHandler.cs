using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Infrastructure;

namespace CommandPattern.Commands.Brake
{
    public class BrakeCommandHandler
        : ICommandHandler<BrakeCommand>
    {
        public void Handle(BrakeCommand command)
        {
            Console.WriteLine("Performing brake command");
        }
    }
}
