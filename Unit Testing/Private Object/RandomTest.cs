using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp13;

namespace RandomTestProject
{
    [TestClass]
    public class RandomTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // USING PRIVATE OBJECT
            Random1 random_obj1 = new Random1(3);
            PrivateObject priv = new PrivateObject(random_obj1);
            Assert.AreEqual((int)priv.GetFieldOrProperty("a"), 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // USING PRIVATE OBJECT // UPDATING VALUE OF A TO 1 AND ASSERTING
            Random1 random_obj1 = new Random1(3);
            PrivateObject priv = new PrivateObject(random_obj1);
            priv.SetFieldOrProperty("a", 1);
            Assert.AreEqual((int)priv.GetFieldOrProperty("a"), 1);
        }

        [TestMethod]
        public void SquaredMethodTest()
        {
            Random1 random_obj1 = new Random1(4);

            Assert.AreEqual(16, random_obj1.squared());
        }
     
    }
}
