using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson06;

namespace Lesson06Test
{
    [TestClass]
    public class PointMathTest
    {
        [TestMethod]
        public void PointAddition()
        {
            var calculator = new CalculatorInt32();
            var p1 = new Point<int>(1, 1);
            var p2 = new Point<int>(2, 2);

            var p3 = calculator.AddPoints(p1, p2);

            Assert.AreEqual(p3.X, 3);
            Assert.AreEqual(p3.Y, 3);

        }
    }
}
