using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using TypedFactory.Providers;

namespace CommandPattern.Services
{
    public class CommandProcessor
    {
        private readonly IHandlerProvider handlerProvider;

        public CommandProcessor(
            IHandlerProvider handlerProvider
            )
        {
            this.handlerProvider = handlerProvider;
        }

        public void ProcessCommand(ICommand command)
        {
            var handlers = handlerProvider.GetAll(command);

            foreach(var handler in handlers)
            {
                handler.Handle(command);
            }
        }
    }
}
