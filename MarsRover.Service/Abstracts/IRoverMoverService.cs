using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Commands;
using MarsRover.Models;

namespace MarsRover.Service.Abstracts
{
    public interface IRoverMoverService
    {
        Queue<Command> CreateCommandsFromDimensions(string dimensions);

        Position GetPositionFromDimensions(Position position, string dimensions);
    }
}
