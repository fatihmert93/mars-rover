using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Actions;
using MarsRover.Infrastructure.Commands;
using MarsRover.Models;
using MarsRover.Service.Abstracts;

namespace MarsRover.Service
{
    public class RoverMoverService : IRoverMoverService
    {
        public Queue<Command> CreateCommandsFromDimensions(string dimensions)
        {
            Queue<Command> commands = new Queue<Command>();
            char[] instructions = dimensions.ToCharArray();
            foreach (var instruction in instructions)
            {
                Command command = CommandFactory.CreateCommandFromDimension(instruction);
                commands.Enqueue(command);
            }

            return commands;
        }

        public Position GetPositionFromDimensions(Position position, string dimensions)
        {
            Queue<Command> commands = this.CreateCommandsFromDimensions(dimensions);
            IAction action = new MoveAction(position);

            IActionVisitor moveActionVisitor = new MoveActionVisitor();
            foreach (var command in commands)
            {
                moveActionVisitor.PushNewCommand(command);
            }

            action.Accept(moveActionVisitor);

            moveActionVisitor.Visit(action);

            return action.position;
        }
    }
}
