using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            silnia test = new silnia();
            //test dla n=0
            test.n = 0;
            Assert.AreEqual(test.Oblicz(), 1);
        }
    }
}
