using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Position
    {
        public Coordinate Coordinate { get; set; }
        public Direction Direction { get; set; }
    }
}
