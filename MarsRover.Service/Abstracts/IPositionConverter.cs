using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Service.Abstracts
{
    public interface IPositionConverter
    {
        Position ParseFirstInputLine(string firstInputLine);

        string ConvertToString(Position position);
    }
}
