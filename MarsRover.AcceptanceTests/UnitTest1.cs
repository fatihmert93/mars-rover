using Autofac;
using Autofac.Extensions.DependencyInjection;
using MarsRover.Infrastructure.Exception.Framework;
using MarsRover.Models;
using MarsRover.Service;
using MarsRover.Service.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace MarsRover.AcceptanceTests
{
    public class Tests
    {
        private IRoverMoverService moverService;
        private IPositionConverter positionConverter;

        [SetUp]
        public void Setup()
        {
            var serviceCollection = new ServiceCollection();

            var containerBuilder = new ContainerBuilder();

            containerBuilder.Populate(serviceCollection);

            containerBuilder.RegisterType<ExceptionManager>().As<IExceptionManager>();

            containerBuilder.RegisterType<RoverMoverService>().As<IRoverMoverService>();

            containerBuilder.RegisterType<PlateCheckerService>().As<IPlateCheckerService>();

            containerBuilder.RegisterType<DirectionConverter>().As<IDirectionConverter>();

            containerBuilder.RegisterType<PositionConverter>().As<IPositionConverter>();

            var container = containerBuilder.Build();
            var serviceProvider = new AutofacServiceProvider(container);

            this.moverService = container.Resolve<IRoverMoverService>();

            IExceptionManager exceptionManager = container.Resolve<IExceptionManager>();

            IPlateCheckerService plateCheckerService = container.Resolve<IPlateCheckerService>();

            this.positionConverter = container.Resolve<IPositionConverter>();


            moverService = new RoverMoverService();

        }

        [Test]
        public void Test1()
        {
            string firstPosition = "1 2 N";

            var position = this.positionConverter.ParseFirstInputLine(firstPosition);
            Assert.IsNotNull(position);
                
            var commands = "LMLMLMLMM";

            Position lastPositionFromDimensions = moverService.GetPositionFromDimensions(position, commands);

            string lastPositionString = this.positionConverter.ConvertToString(lastPositionFromDimensions);

            Assert.AreEqual("1 3 N", lastPositionString);
        }

        [Test]
        public void Test2()
        {
            string firstPosition = "3 3 E";

            var position = this.positionConverter.ParseFirstInputLine(firstPosition);
            Assert.IsNotNull(position);

            var commands = "MMRMMRMRRM";

            Position lastPositionFromDimensions = moverService.GetPositionFromDimensions(position, commands);

            string lastPositionString = this.positionConverter.ConvertToString(lastPositionFromDimensions);

            Assert.AreEqual("5 1 E", lastPositionString);
        }
    }
}