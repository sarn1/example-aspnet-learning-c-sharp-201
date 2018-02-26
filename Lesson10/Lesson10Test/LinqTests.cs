using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson10Test
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

        public IEnumerable<string> DoSomethingWithJNames(bool namesWithE = false)
        {
            var results = _names.Where(n => n.StartsWith("J"));

            if (namesWithE)
            {
                results = results.Where(n => n[1] == 'e');
            }

            foreach (var name in results)
            {
                // do something with name
            }

            #region Stuff to return results
            return results.ToArray();
            #endregion
        }

        public IEnumerable<char> DoSomethingWithJNames2()
        {
            var efficient = _names.Where(n => n.StartsWith("J"))
                .Select(n => n.Last());

            var namesWithJ = _names.Where(n => n.StartsWith("J"));
            var lastChars = namesWithJ.Select(n => n.Last());


            foreach (var name in efficient)
            {
                // do something with name
            }

            foreach (var name in namesWithJ)
            {
                // do something with name
                var character = name.Last();
            }

            //foreach (var chars in lastChars)
            //{
                
            //}

            #region Stuff to return results
            return efficient.ToArray();
            #endregion
        }

        [TestMethod]
        public void WhileTests()
        {
            var namesWithJ = DoSomethingWithJNames();

            Assert.AreEqual(namesWithJ.Count(), 3);

            var namesWithE = DoSomethingWithJNames(true);

            Assert.AreEqual(namesWithE.Count(), 1);
        }

        [TestMethod]
        public void QueryReuse()
        {
            var namesWithJ = _names.Where(n => n.StartsWith("J"));

            Assert.AreEqual(namesWithJ.Count(), 3);

            _names.Add("Jim");

            Assert.AreEqual(namesWithJ.Count(), 4);

        }
    }
}
