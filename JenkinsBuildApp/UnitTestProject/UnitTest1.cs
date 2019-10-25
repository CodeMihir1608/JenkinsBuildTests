using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsBuildApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Print Hello", Program.printtext());
        }
    }
}
