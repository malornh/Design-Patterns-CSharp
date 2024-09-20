using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    public class Square
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public double getSide()
        {
            return _side;
        }
    }
}
