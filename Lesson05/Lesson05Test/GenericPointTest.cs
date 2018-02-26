using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson05;

namespace Lesson05Test
{
    [TestClass]
    public class GenericPointTest
    {
        [TestMethod]
        public void Int32Point()
        {
            var p1 = new Point<int>(1, 1);

            Assert.AreEqual(p1.X, 1);
            Assert.AreEqual(p1.Y, 1);
        }

        [TestMethod]
        public void FloatPoint()
        {
            var p1 = new Point<float>(1.1f, 1.1f);

            Assert.AreEqual(p1.X, 1.1f);
            Assert.AreEqual(p1.Y, 1.1f);
        }
    }
}
