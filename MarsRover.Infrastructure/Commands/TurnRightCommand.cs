using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Commands
{
    internal class TurnRightCommand : Command
    {
        public override Position Execute(Position position)
        {
            switch (position.Direction)
            {
                case Direction.North:
                    position.Direction = Direction.East;
                    break;
                case Direction.West:
                    position.Direction = Direction.North;
                    break;
                case Direction.East:
                    position.Direction = Direction.South;
                    break;
                case Direction.South:
                    position.Direction = Direction.West;
                    break;
            }

            return position;
        }
    }
}
