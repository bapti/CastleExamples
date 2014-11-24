﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Infrastructure;

namespace CommandPattern.Commands.Brake
{
    public class BrakeCommand : ICommand
    {
        public string Name
        {
            get { return "Brake"; }
        }
    }
}
