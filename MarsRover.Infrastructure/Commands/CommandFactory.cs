using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Infrastructure.Commands
{
    public static class CommandFactory
    {
        public static Command CreateCommandFromDimension(char dimension)
        {
            switch (dimension)
            {
                case 'M':
                    return new MoveCommand();
                case 'L':
                    return new TurnLefCommand();
                case 'R':
                    return new TurnRightCommand();
                default:
                    return new NoActionCommand();
            }
        }
    }
}
