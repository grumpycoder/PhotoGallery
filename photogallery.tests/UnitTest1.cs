using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace photogallery.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(a, b);
        }
    }
}
