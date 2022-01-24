using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Exception.Models;

namespace MarsRover.Infrastructure.Exception.Framework.Handlers
{
    internal class ExceptionHandlerFactories
    {
        internal static ExceptionHandlerFactory GetFactory(System.Exception e)
        {
            if (e is CoreLevelException)
                return new CoreLevelHandlerFactory();
            else if (e is CriticalLevelException)
                return new CriticalLevelHandlerFactory();
            else if (e is UserLevelException)
                return new UserLevelHandlerFactory();
            else
                return new NetLevelHandlerFactory();
        }
    }
}
