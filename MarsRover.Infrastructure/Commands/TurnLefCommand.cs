using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Commands
{
    internal class TurnLefCommand : Command
    {
        public override Position Execute(Position position)
        {
            switch (position.Direction)
            {
                case Direction.North:
                    position.Direction = Direction.West;
                    break;
                case Direction.West:
                    position.Direction = Direction.South;
                    break;
                case Direction.East:
                    position.Direction = Direction.North;
                    break;
                case Direction.South:
                    position.Direction = Direction.East;
                    break;
            }

            return position;
        }
    }
}
