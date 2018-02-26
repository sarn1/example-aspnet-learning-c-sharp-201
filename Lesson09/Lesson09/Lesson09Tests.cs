using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Lesson09
{
    [TestClass]
    public class Lesson09Tests
    {
        [TestMethod]
        public void GenericListTest()
        {
            var names = new List<string>()
            {
                "Jeremy",
                "Casey",
                "Jimbo",
                "Bill"
            };

            var namesWithJ = names.Where(s => s.StartsWith("J"));

            var namesWithJ2 = from s in names
                              where s.StartsWith("J")
                              select s;

            Assert.AreEqual(namesWithJ.Count(), 2);
            Assert.AreEqual(namesWithJ2.Count(), 2);

        }

        [TestMethod]
        public void LegacyListTest()
        {
            var names = new ArrayList()
            {
                "Jeremy",
                "Casey",
                "Jimbo",
                "Bill"
            };

            var namesWithJ = names.Cast<string>()
                .Where(s => s.StartsWith("J"));

            var namesWithJ2 = from string s in names
                              where s.StartsWith("J")
                              select s;

            Assert.AreEqual(namesWithJ.Count(), 2);
            Assert.AreEqual(namesWithJ2.Count(), 2);

        }
    }
}
