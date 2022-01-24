using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Commands;

namespace MarsRover.Infrastructure.Actions
{
    public abstract class IActionVisitor
    {
        private Queue<Command> commands;

        public IActionVisitor()
        {
            commands = new Queue<Command>();
        }

        public abstract void PushNewCommand(Command command);
        public abstract void Visit(IAction action);
    }
}
