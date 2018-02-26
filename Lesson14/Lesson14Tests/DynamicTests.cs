using System;
using Lesson14;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson14Tests
{
    [TestClass]
    public class DynamicTests
    {
        [TestMethod]
        public void SimpleTests()
        {
            dynamic simple = new Simple();

            simple.foo = "hello dynamic";

            Assert.AreEqual(simple.foo, "hello dynamic");
        }

        [TestMethod]
        public void XmlTests()
        {
            dynamic doc = new Xml();

            doc.contact(Xml.Element(c =>
            {
                c.firstname("Jeremy");
                c.lastname("McPeak", Xml.Element(l =>
                {
                    l.foo("hi");
                }));
            }));

            Console.WriteLine(doc.ToString());
        }
    }
}
