using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Infrastructure;

namespace CommandPattern.Commands.Brake
{
    public class BrakeCommand : ICommand
    {
        public BrakeCommand()
        {
            Log = new List<String>();
        }
        public List<String> Log {get;set;}

        public string Name
        {
            get { return "Brake"; }
        }

    }
}
