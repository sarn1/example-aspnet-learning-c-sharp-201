using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    public class Point<TCoord, TCalc>
        where TCalc : ICalculator<TCoord>, new()
    {
        public TCoord X { get; set; }
        public TCoord Y { get; set; }

        private static readonly TCalc _calculator = new TCalc();

        public Point(TCoord x, TCoord y)
        {
            X = x;
            Y = y;
        }

        public static Point<TCoord, TCalc> operator +(Point<TCoord, TCalc> p1, Point<TCoord, TCalc> p2)
        {
            var x = _calculator.Add(p1.X, p2.X);
            var y = _calculator.Add(p1.Y, p2.Y);

            return new Point<TCoord, TCalc>(x, y);
        }

        public static Point<TCoord, TCalc> operator -(Point<TCoord, TCalc> p1, Point<TCoord, TCalc> p2)
        {
            var x = _calculator.Subtract(p1.X, p2.X);
            var y = _calculator.Subtract(p1.Y, p2.Y);

            return new Point<TCoord, TCalc>(x, y);
        }
    }
}
