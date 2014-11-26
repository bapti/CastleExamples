using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Infrastructure;

namespace CommandPattern.Commands.Accelerate
{
    public class AccelerateCommand : ICommand
    {
        public AccelerateCommand()
        {
            Log = new List<String>();
        }

        public List<String> Log {get;set;}

        public string Name
        {
            get { return "Zoom zoom"; }
        }
    }
}
