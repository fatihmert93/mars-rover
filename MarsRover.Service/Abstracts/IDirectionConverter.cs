using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Service.Abstracts
{
    public interface IDirectionConverter
    {
        Tuple<bool, Direction> TryParseDirection(char directionString);

        string GetDirectionString(Direction direction);
    }
}
