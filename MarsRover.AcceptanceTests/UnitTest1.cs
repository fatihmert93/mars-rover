using MarsRover.Models;
using MarsRover.Service;
using MarsRover.Service.Abstracts;
using NUnit.Framework;

namespace MarsRover.AcceptanceTests
{
    public class Tests
    {
        private IRoverMoverService moverService;

        [SetUp]
        public void Setup()
        {
            moverService = new RoverMoverService();

        }

        [Test]
        public void Test1()
        {
            string firstPosition = "1 2 N";

            var position = PositionConverter.ParseFirstInputLine(firstPosition);
            Assert.IsNotNull(position);
                
            var commands = "LMLMLMLMM";

            Position lastPositionFromDimensions = moverService.GetPositionFromDimensions(position, commands);

            string lastPositionString = lastPositionFromDimensions.ConvertToString();

            Assert.Pass("1 3 N");
        }

        [Test]
        public void Test2()
        {
            string firstPosition = "3 3 E";

            var position = PositionConverter.ParseFirstInputLine(firstPosition);
            Assert.IsNotNull(position);

            var commands = "MMRMMRMRRM";

            Position lastPositionFromDimensions = moverService.GetPositionFromDimensions(position, commands);

            string lastPositionString = lastPositionFromDimensions.ConvertToString();

            Assert.Pass("5 1 E");
        }
    }
}