using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Commands
{
    public abstract class Command
    {
        public abstract Position Execute(Position position);
    }
}
