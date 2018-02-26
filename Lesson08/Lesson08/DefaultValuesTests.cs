using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson08
{
    [TestClass]
    public class DefaultValuesTests
    {
        [TestMethod]
        public void NonTests()
        {
            int intFoo = 0;
            decimal decFoo = 0;
            bool boolFoo = false;

            DateTime dtFoo = DateTime.MinValue;

            string stringFoo = null;

            Assert.AreEqual(0, default(int));
            Assert.AreEqual(null, default(int?));

        }
    }
}
