using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    public struct Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T x, T y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
