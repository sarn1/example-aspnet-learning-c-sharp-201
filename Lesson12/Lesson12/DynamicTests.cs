using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson12
{
    [TestClass]
    public class DynamicTests
    {
        [TestMethod]
        public void CreateDynamic()
        {
            dynamic foo = "howdy";

            var bar = foo + " world";

            Console.WriteLine(bar);
        }

        [TestMethod]
        public void ConvertDynamic()
        {
            dynamic foo = "howdy";

            int bar = Convert.ToInt32(foo);
        }
    }
}
