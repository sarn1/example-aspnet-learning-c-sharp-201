using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson07;


namespace Lesson07Test
{
    [TestClass]
    public class PointMathTest
    {
        [TestMethod]
        public void PointAddition()
        {
            //var calculator = new CalculatorInt32();
            var p1 = new PointInt32(1, 1);
            var p2 = new PointInt32(2, 2);

            //var p3 = calculator.AddPoints(p1, p2);

            var p3 = p1 + p2;

            Assert.AreEqual(p3.X, 3);
            Assert.AreEqual(p3.Y, 3);

        }
    }
}
