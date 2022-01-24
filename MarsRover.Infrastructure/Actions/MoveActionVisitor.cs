using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Commands;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Actions
{
    public class MoveActionVisitor : IActionVisitor
    {
        private Queue<Command> commands = new Queue<Command>();

        public override void PushNewCommand(Command command)
        {
            commands.Enqueue(command);
        }

        public override void Visit(IAction action)
        {
            while (commands.TryDequeue(out Command? command))
            {
                Position pos = action.position;
                command.Execute(pos);
            }
        }
    }
}
