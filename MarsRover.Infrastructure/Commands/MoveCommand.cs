using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Commands
{
    internal class MoveCommand : Command
    {
        public override Position Execute(Position position)
        {
            switch (position.Direction)
            {
                case Direction.North:
                    position.Coordinate.Y++;
                    break;
                case Direction.South:
                    position.Coordinate.Y--;
                    break;
                case Direction.East:
                    position.Coordinate.X++;
                    break;
                case Direction.West:
                    position.Coordinate.X--;
                    break;
            }

            return position;
        }
    }
}
