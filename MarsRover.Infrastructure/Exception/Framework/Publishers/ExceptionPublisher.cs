using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Infrastructure.Exception.Framework.Publishers
{
    internal abstract class ExceptionPublisher
    {
        internal abstract void Publish(System.Exception e);
    }
}
