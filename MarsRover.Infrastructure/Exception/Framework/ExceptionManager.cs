using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Exception.Framework.Handlers;
using MarsRover.Infrastructure.Exception.Framework.Publishers;
using MarsRover.Infrastructure.Exception.Framework.Rules;

namespace MarsRover.Infrastructure.Exception.Framework
{
    public class ExceptionManager : IExceptionManager
    {
        public void Handle(System.Exception e)
        {
            ExceptionHandlerFactory factory = ExceptionHandlerFactories.GetFactory(e);
            PublisherList list = factory.GetPublishers();
            ExceptionRule rule = factory.GetRule();
            rule.Run(e, list);
        }
    }
}
