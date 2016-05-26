using System;
using Dianond.CSharpExtensionMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExtensionMethodUnitTest
{
    [TestClass]
    public class StringExtensionUnitTest
    {
        [TestMethod]
        public void TestIsNullOrEmpty()
        {
            string u = null;
            Assert.AreEqual(true, u.IsNullOrEmpty());
        }

        [TestMethod]
        public void TestComputeMD5Hash1()
        {
            string s = null;
            Assert.AreEqual(null, s.ComputeMD5Hash());
        }

        [TestMethod]
        public void TestComputeMD5Hash2()
        {
            string s = "123";
            Assert.AreEqual("202cb962ac59075b964b07152d234b70", s.ComputeMD5Hash());
        }

        [TestMethod]
        public void TestIsMatch()
        {
            string s = "123123123";
            Assert.AreEqual(true, s.IsMatch(@"\d"));
        }

        [TestMethod]
        public void TestMatch()
        {
            string s = "123123123";
            Assert.AreEqual("1", s.Match(@"\d"));
        }
    }
}
