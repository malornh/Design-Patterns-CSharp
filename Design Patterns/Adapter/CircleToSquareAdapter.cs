using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    public class CircleToSquareAdapter : Square
    {
        public CircleToSquareAdapter(Circle circle) : base(circle.getRadius() * 2)
        {
              
        }
    }
}
