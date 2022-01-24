using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Infrastructure.Exception.Framework.Publishers
{
    internal class MailExceptionPublisher : ExceptionPublisher
    {
        internal override void Publish(System.Exception e)
        {
            // sending mail
        }
    }
}
