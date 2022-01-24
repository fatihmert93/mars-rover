using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Infrastructure.Exception.Framework.Publishers;

namespace MarsRover.Infrastructure.Exception.Framework.Rules
{
    internal class AllRule : ExceptionRule
    {
        internal override void Run(System.Exception e, PublisherList list)
        {
            foreach (ExceptionPublisher publisher in list)
            {
                try
                {
                    publisher.Publish(e);
                }
                catch
                {

                }
            }
        }
    }
}
