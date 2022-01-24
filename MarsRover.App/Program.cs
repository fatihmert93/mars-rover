// See https://aka.ms/new-console-template for more information

using Autofac;
using Autofac.Extensions.DependencyInjection;
using MarsRover.Infrastructure.Exception.Framework;
using MarsRover.Infrastructure.Exception.Models;
using MarsRover.Models;
using MarsRover.Service;
using MarsRover.Service.Abstracts;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

var containerBuilder = new ContainerBuilder();

containerBuilder.Populate(serviceCollection);

containerBuilder.RegisterType<ExceptionManager>().As<IExceptionManager>();

containerBuilder.RegisterType<DirectionConverter>().As<IDirectionConverter>();

containerBuilder.RegisterType<PositionConverter>().As<IPositionConverter>();

containerBuilder.RegisterType<RoverMoverService>().As<IRoverMoverService>();

containerBuilder.RegisterType<PlateCheckerService>().As<IPlateCheckerService>();

var container = containerBuilder.Build();
var serviceProvider = new AutofacServiceProvider(container);

IRoverMoverService service = container.Resolve<IRoverMoverService>();

IExceptionManager exceptionManager = container.Resolve<IExceptionManager>();

IPlateCheckerService plateCheckerService = container.Resolve<IPlateCheckerService>();

IPositionConverter positionConverter = container.Resolve<IPositionConverter>();


var inputDimensions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Plate plate = new Plate(inputDimensions[0], inputDimensions[1]);

while (true)
{
    try
    {
        var position = positionConverter.ParseFirstInputLine(Console.ReadLine());
        if (position == null)
        {
            throw new UserLevelException();
        }
        var commands = Console.ReadLine();

        Position lastPositionFromDimensions = service.GetPositionFromDimensions(position, commands);

        bool boundaryCheck = plateCheckerService.CheckBoundary(plate, lastPositionFromDimensions);

        if (!boundaryCheck)
        {
            throw new CriticalLevelException();
        }

        Console.WriteLine(positionConverter.ConvertToString(position));
    }
    catch (Exception e)
    {
        exceptionManager.Handle(e);
    }

    
}