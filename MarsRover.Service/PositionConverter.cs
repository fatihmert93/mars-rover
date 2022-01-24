using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;
using MarsRover.Service.Abstracts;

namespace MarsRover.Service
{
    public class PositionConverter : IPositionConverter
    {
        private readonly IDirectionConverter _directionConverter;

        public PositionConverter(IDirectionConverter directionConverter)
        {
            this._directionConverter = directionConverter;
        }

        public Position ParseFirstInputLine(string firstInputLine)
        {
            if (string.IsNullOrWhiteSpace(firstInputLine))
                return null;
            var lineParts = firstInputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (lineParts.Length < 3)
                return null;
            var successX = int.TryParse(lineParts[0], out var x);
            var successY = int.TryParse(lineParts[1], out var y);
            var successDirection = this._directionConverter.TryParseDirection(lineParts[2].ToCharArray()[0]);
            if (!(successX && successY && successDirection.Item1))
                return null;
            return new Position
            {
                Direction = successDirection.Item2,
                Coordinate = new Coordinate()
                {
                    X = x,
                    Y = y
                }
            };
        }

        public string ConvertToString(Position position)
        {
            return string.Format(position.Coordinate.X + " " + position.Coordinate.Y + " " +
                                 this._directionConverter.GetDirectionString(position.Direction));
        }
    }
}
