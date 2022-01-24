using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;

namespace MarsRover.Infrastructure.Actions
{
    public class MoveAction : IAction
    {
        public MoveAction(Position position)
        {
            this.position = position;
        }
        
        public override void Accept(IActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
