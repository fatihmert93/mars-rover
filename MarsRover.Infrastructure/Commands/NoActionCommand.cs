using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Commands
{
    internal class NoActionCommand : Command
    {
        public override Position Execute(Position position)
        {
            return position;
        }
    }
}
