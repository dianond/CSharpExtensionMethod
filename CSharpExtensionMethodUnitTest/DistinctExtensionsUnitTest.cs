using System;
using System.Linq;
using Dianond.CSharpExtensionMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExtensionMethodUnitTest
{
    [TestClass]
    public class DistinctExtensionsUnitTest
    {
        [TestMethod]
        public void TestDistinct()
        {
            var data1 = new[]
            {
                new Person {ID = 1, Name = "001"},
                new Person {ID = 1, Name = "002"}
            };
            var ps1 = data1
                .Distinct(p => p.ID)
                .ToArray();
            Assert.AreEqual(1, ps1.Length);
        }
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
