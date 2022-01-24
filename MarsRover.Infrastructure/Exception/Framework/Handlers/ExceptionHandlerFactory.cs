using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Exception.Framework.Publishers;
using MarsRover.Infrastructure.Exception.Framework.Rules;

namespace MarsRover.Infrastructure.Exception.Framework.Handlers
{
    internal abstract class ExceptionHandlerFactory
    {
        internal abstract PublisherList GetPublishers();
        internal abstract ExceptionRule GetRule();
    }
}
