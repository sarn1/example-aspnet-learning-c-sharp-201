using System;
using System.Dynamic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lesson13
{
    [TestClass]
    public class DynamicTests
    {
        [TestMethod]
        public void IsThisDynamic()
        {
            dynamic foo = "hello, world";
        }

        public dynamic CreatePerson(dynamic firstName, dynamic lastName)
        {
            dynamic person = new ExpandoObject();

            person.FirstName = firstName;
            person.LastName = lastName;

            return person;
        }

        [TestMethod]
        public void ExpandoObjectTests()
        {
            dynamic people = new List<dynamic>();
            var me = CreatePerson("Jeremy", "McPeak");

            people.Add(me);
            people.Add(CreatePerson("John", "Doe"));

            var person = (from p in people as List<dynamic>
                             where p.FirstName == "Jeremy"
                             select p).Single();

            Assert.AreEqual(people.Count, 2);
            Assert.AreEqual(me, person);

        }
    }
}
