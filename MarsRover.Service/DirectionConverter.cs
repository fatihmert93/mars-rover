using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Service
{
    public class DirectionConverter
    {

        public static Tuple<bool, Direction> TryParseDirection(char directionString)
        {
            Direction direction = Direction.North;
            var success = false;
            switch (directionString)
            {
                case 'N':
                case 'n':
                    direction = Direction.North;
                    success = true;
                    break;
                case 'E':
                case 'e':
                    direction = Direction.East;
                    success = true;
                    break;
                case 'W':
                case 'w':
                    direction = Direction.West;
                    success = true;
                    break;
                case 'S':
                case 's':
                    direction = Direction.South;
                    success = true;
                    break;
            }
            return new Tuple<bool, Direction>(success, direction);
        }

        public static string GetDirectionString(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return "N";
                case Direction.South:
                    return "S";
                case Direction.East:
                    return "E";
                case Direction.West:
                    return "W";
            }
            return null;
        }

    }
}
