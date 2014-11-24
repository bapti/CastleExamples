using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Infrastructure;

namespace CommandPattern.Services
{
    public class CommandProcessor
    {
        private readonly ICommandHandlerFactory factory;

        public CommandProcessor(
            ICommandHandlerFactory factory
            )
        {
            this.factory = factory;
        }

        public void ProcessCommand(ICommand command)
        {
            var handler = factory.Create(command);

            handler.Handle(command);
        }
    }
}
