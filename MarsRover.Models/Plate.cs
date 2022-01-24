using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Plate
    {
        public Plate(double x, double y)
        {
            LeftBottomCoordinate = new Coordinate()
            {
                X = 0,
                Y = 0,
            };

            RightTopCoordinate = new Coordinate()
            {
                X = x,
                Y = y,
            };
        }

        public Coordinate LeftBottomCoordinate { get; set; }
        public Coordinate RightTopCoordinate { get; set; }

        public Coordinate GetCoordinateFromDimension(string dimension)
        {
            return null;
        }
    }
}
