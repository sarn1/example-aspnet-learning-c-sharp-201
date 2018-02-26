using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson03;

namespace Lesson03Test
{
    [TestClass]
    public class ConversionTests
    {
        [TestMethod]
        public void ImplicitTest()
        {
            var digit = new Digit(5);
            int foo = digit;

            Assert.AreEqual(foo, 5);
        }

        [TestMethod]
        public void ExplicitTest()
        {
            int foo2 = 5;
            Digit digit2 = (Digit)foo2;

            Assert.AreEqual(digit2.Value, 5);
        }
    }
}
