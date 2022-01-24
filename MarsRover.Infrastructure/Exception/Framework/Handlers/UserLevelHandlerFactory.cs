using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Exception.Framework.Publishers;
using MarsRover.Infrastructure.Exception.Framework.Rules;

namespace MarsRover.Infrastructure.Exception.Framework.Handlers
{
    internal class UserLevelHandlerFactory : ExceptionHandlerFactory
    {
        internal override PublisherList GetPublishers()
        {
            PublisherList list = new PublisherList();
            return list;
        }

        internal override ExceptionRule GetRule()
        {
            return new NoneRule();
        }
    }
}
