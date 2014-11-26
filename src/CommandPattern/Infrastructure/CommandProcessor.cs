using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Infrastructure;

namespace CommandPattern.Infrastructure
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

        public void ProcessCommand<TCommand>(TCommand command)
            where TCommand : class, ICommand
        {
            var handler = factory.Create<TCommand>();

            handler.Handle(command);
        }
    }
}
