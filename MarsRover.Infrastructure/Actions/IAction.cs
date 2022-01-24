using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Actions
{
    public abstract class IAction
    {
        public Position position;
        public abstract void Accept(IActionVisitor visitor);
    }
}
