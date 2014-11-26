using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Infrastructure;

namespace CommandPattern.Handlers
{
    public class LoggingDecorator<TCommand> : ICommandHandler<TCommand>
        where TCommand : class, ICommand
    {
        private readonly ICommandHandler<TCommand> decoratedCommand;
        private readonly ILogger logger;

        public LoggingDecorator(
            ICommandHandler<TCommand> decoratedCommand,
            ILogger logger
            )
        {
            this.decoratedCommand = decoratedCommand;
            this.logger = logger;
        }

        public void Handle(TCommand command)
        {
            command.Log.Add("logging");
            
            logger.Info("Logging command " + command.Name);

            decoratedCommand.Handle(command);
        }
    }
}
