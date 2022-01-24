using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Infrastructure.Exception.Framework
{
    public interface IExceptionManager
    {
        void Handle(System.Exception e);
    }
}
