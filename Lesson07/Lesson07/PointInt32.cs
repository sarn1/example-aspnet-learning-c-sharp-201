using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    public class PointInt32 : Point<int, CalculatorInt32>
    {
        public PointInt32(int x, int y) : base(x, y) {}
    }
}
