using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service.Checkers
{
    internal class PositionXDimensionChecker : Checker
    {
        public override bool Check(double val1, double val2)
        {
            return (val2 > 0 && val1 >= val2);
        }
    }
}
