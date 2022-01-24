// See https://aka.ms/new-console-template for more information

using MarsRover.Models;
using MarsRover.Service;
using MarsRover.Service.Abstracts;

Console.WriteLine("Hello, World!");


IRoverMoverService service = new RoverMoverService();

var inputDimensions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

while (true)
{
    var position = PositionConverter.ParseFirstInputLine(Console.ReadLine());
    if (position == null)
        break;
    var commands = Console.ReadLine();
    
    Position lastPositionFromDimensions = service.GetPositionFromDimensions(position, commands);

    WritePosition(lastPositionFromDimensions);
}


static void WritePosition(Position position)
{
    Console.WriteLine(position.ConvertToString());
}