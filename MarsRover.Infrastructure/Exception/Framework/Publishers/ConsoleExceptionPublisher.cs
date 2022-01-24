using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Infrastructure.Exception.Framework.Publishers
{
    internal class ConsoleExceptionPublisher : ExceptionPublisher
    {
        internal override void Publish(System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
