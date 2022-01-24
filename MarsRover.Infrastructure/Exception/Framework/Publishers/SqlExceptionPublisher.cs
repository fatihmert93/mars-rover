using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Infrastructure.Exception.Framework.Publishers
{
    internal class SqlExceptionPublisher : ExceptionPublisher
    {
        internal override void Publish(System.Exception e)
        {
            // logging exception to db
        }
    }
}
