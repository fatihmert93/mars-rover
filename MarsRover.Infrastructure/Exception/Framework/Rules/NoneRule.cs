using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Exception.Framework.Publishers;

namespace MarsRover.Infrastructure.Exception.Framework.Rules
{
    internal class NoneRule : ExceptionRule
    {
        internal override void Run(System.Exception e, PublisherList list)
        {
            // none is executing
        }
    }
}
