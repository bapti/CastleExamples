using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;

namespace CommandPattern.Handlers
{
    public class DriveHandler 
        : ICommandHandler<DriveCommand>
    {
        public void Handle(DriveCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
