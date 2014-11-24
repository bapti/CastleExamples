using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Infrastructure;

namespace CommandPattern.Commands.Accelerate
{
    public class AccelerateCommandHandler 
        : ICommandHandler<AccelerateCommand>
    {
        public void Handle(AccelerateCommand command)
        {
            Console.WriteLine("Performing accelerate command");
        }
    }
}
