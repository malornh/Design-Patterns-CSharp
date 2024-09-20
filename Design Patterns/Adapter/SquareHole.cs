using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    public class SquareHole
    {
        private double _sideLength;

        public SquareHole(double sideLength)
        {
            _sideLength = sideLength;
        }

        public bool canFit(Square square)
        {
            return _sideLength >= square.getSide();
        }
    }
}
