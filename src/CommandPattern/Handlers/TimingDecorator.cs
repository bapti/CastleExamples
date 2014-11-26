using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Infrastructure;

namespace CommandPattern.Handlers
{
    public class TimingDecorator<TCommand> : ICommandHandler<TCommand>
        where TCommand : class, ICommand
    {
        private readonly ICommandHandler<TCommand> decoratedCommand;
        private readonly IMetrics metrics;

        public TimingDecorator(
            ICommandHandler<TCommand> decoratedCommand,
            IMetrics metrics
            )
        {
            this.decoratedCommand = decoratedCommand;
            this.metrics = metrics;
        }

        public void Handle(TCommand command)
        {
            command.Log.Add("timing");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            decoratedCommand.Handle(command);

            sw.Stop();
            metrics.Timing(command.Name, sw.Elapsed);
        }
    }
}
