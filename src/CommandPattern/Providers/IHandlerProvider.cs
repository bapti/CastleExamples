using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Handlers;

namespace TypedFactory.Providers
{
    public interface IHandlerProvider : IDisposable
    {
        ICommandHandler<TCommand>[] GetAll<TCommand>(TCommand command)
            where TCommand : class, ICommand;

        void Release<TCommand>(ICommandHandler<TCommand>[] handlers)
            where TCommand : class, ICommand;
    }
}
