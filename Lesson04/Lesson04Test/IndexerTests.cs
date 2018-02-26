using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lesson04;
using System.Linq;

namespace Lesson04Test
{
    [TestClass]
    public class IndexerTests
    {
        [TestMethod]
        public void SquareBracket()
        {
            var strings = new[]
            {
                "String 1",
                "String 2",
                "String 3"
            };

            Assert.AreEqual(strings[0], "String 1");
        }

        [TestMethod]
        public void ListSample()
        {
            var sample = new List<string>
            {
                "First String",
                "Second String",
                "Third String"
            };

            Assert.AreEqual(sample[0], "First String");
        }

        [TestMethod]
        public void DictionarySample()
        {
            var sample = new Dictionary<string, int>
            {
                {"First String", 5},
                {"Second String", 10},
                {"Third String", 15}
            };

            Assert.AreEqual(sample["First String"], 5);
        }

        [TestMethod]
        public void IndexerTest()
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var people = new PersonCollection();

            people.Add(person);

            var foo = people[0];

            Assert.AreSame(person, foo);

            var bar = people["John", "Doe"];

            Assert.AreEqual(bar.Count(), 1);
        }
    }
}
