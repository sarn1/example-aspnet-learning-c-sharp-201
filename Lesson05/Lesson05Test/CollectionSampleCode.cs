using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson05Test
{
    [TestClass]
    public class CollectionSampleCode
    {
        [TestMethod]
        public void ArrayListCode()
        {
            var list = new ArrayList();

            list.Add("hello world");
            list.Add(104);
            list.Add(DateTime.Now);

            foreach (var obj in list)
            {
                if (obj is int)
                {
                    //var value = (int) obj;
                }
                else if (obj is string)
                {
                    
                }
            }
        }

        [TestMethod]
        public void GenericListCode()
        {
            var list = new List<int>();
            list.Add(104);
            list.Add(3);
            list.Add(10);

            foreach (var num in list)
            {
                
            }
        }
    }
}
