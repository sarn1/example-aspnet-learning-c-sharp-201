using System;
using Lesson02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson02Test
{
    [TestClass]
    public class EqualityTests
    {
        [TestMethod]
        public void PointEquality()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(1, 1);

            Assert.AreEqual(p1, p2);
            Assert.IsTrue(p1 == p2);
        }

        [TestMethod]
        public void PointInEquality()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(1, 2);

            Assert.AreNotEqual(p1, p2);
            Assert.IsTrue(p1 != p2);
        }

        [TestMethod]
        public void PointEqualsMethod()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(1, 1);
            var p3 = new Point(1, 2);

            Assert.IsTrue(p1.Equals(p2));
            Assert.IsFalse(p1.Equals(null));
            Assert.IsFalse(p1.Equals(1));
            Assert.IsFalse(p1.Equals(p3));
        }
    }
}
