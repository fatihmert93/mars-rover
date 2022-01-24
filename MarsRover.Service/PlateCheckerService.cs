using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;
using MarsRover.Service.Abstracts;
using MarsRover.Service.Checkers;

namespace MarsRover.Service
{
    public class PlateCheckerService : IPlateCheckerService
    {
        public bool CheckBoundary(Plate plate, Position nextPosition)
        {
            var xChecker = new PositionXDimensionChecker();
            var yChecker = new PositionYDimensionChecker();
            var res1 = xChecker.Check(plate.RightTopCoordinate.X, nextPosition.Coordinate.X);
            var res2 = yChecker.Check(plate.RightTopCoordinate.Y, nextPosition.Coordinate.Y);
            return (res1 && res2);
        }
    }
}
