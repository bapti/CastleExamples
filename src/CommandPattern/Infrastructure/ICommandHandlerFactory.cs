using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Handlers;

namespace CommandPattern.Infrastructure
{
    public interface ICommandHandlerFactory : IDisposable
    {
        ICommandHandler<TCommand> Create<TCommand>()
            where TCommand : class, ICommand;

        void Release<TCommand>(ICommandHandler<TCommand> commandHandler)
            where TCommand : class, ICommand;
    }
}
