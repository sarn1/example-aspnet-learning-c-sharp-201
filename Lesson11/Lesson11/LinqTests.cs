using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson11
{
    [TestClass]
    public class LinqTests
    {
        #region Data Source
        private readonly List<string> _names = new List<string>
        {
            "Jeremy",
            "Jim",
            "Chris",
            "Martin",
            "Leo",
            "June"
        };
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            var namesWithJ = _names.Where(n => n.StartsWith("J")).ToArray();

            Assert.AreEqual(namesWithJ.Count(), 3);
            Assert.IsTrue(namesWithJ.Any(n => n.Contains("e")));
        }
    }
}
