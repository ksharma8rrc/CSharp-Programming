using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// change this is needed
using ConsoleApp13;

namespace RandomTestProject
{
    [TestClass]
    public class RandomTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random1 random_obj1 = new Random1(3);

            Assert.AreEqual(random_obj1.a, 3);    
        }

        [TestMethod]
        public void SquaredMethodTest()
        {
            Random1 random_obj1 = new Random1(4);

            Assert.AreEqual(15, random_obj1.squared());
        }
     
    }
}
