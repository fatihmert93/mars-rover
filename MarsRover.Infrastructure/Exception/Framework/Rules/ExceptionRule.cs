using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Exception.Framework.Publishers;

namespace MarsRover.Infrastructure.Exception.Framework.Rules
{
    internal abstract class ExceptionRule
    {
        internal abstract void Run(System.Exception e, PublisherList list);
    }
}
