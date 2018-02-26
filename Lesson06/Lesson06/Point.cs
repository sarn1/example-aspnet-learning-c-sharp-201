using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    public interface ICalculator<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
    }

    public class CalculatorInt32 : ICalculator<int>
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    public static class ICalculatorExtensions
    {
        public static Point<T> AddPoints<T>(this ICalculator<T> calc, Point<T> p1, Point<T> p2)
        {
            var x = calc.Add(p1.X, p2.X);
            var y = calc.Add(p1.Y, p2.Y);

            return new Point<T>(x, y);
        } 
    }

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
