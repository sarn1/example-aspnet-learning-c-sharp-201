using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson01;

namespace Lesson01Test
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void PointAddition()
        {
            var p1 = new Point(1, 5);
            var p2 = new Point(2, 6);
            var p3 = p1 + p2;
            var p4 = p1 + 1;

            Assert.AreEqual(p3, new Point(3, 11));
            Assert.AreEqual(p4, p2);

        }

        [TestMethod]
        public void PointSubtraction()
        {
            var p1 = new Point(1, 5);
            var p2 = new Point(2, 6);
            var p3 = p1 - p2;
            var p4 = p1 - 1;

            Assert.AreEqual(p3, new Point(-1, -1));
            Assert.AreEqual(p4, new Point(0, 4));

        }
    }
}
