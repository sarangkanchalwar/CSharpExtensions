using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SK.CSharpExtensions;

namespace SK.ExtensionsTest
{
    [TestClass]
    public class ListExtensionUnitTests
    {
        private List<int> numbers = new List<int>()
        {
           { 55 },
           { 12 },
           { 41 },
           { 71 },
           { 22 },
           { 93 },
           { 34 },
           { 88 },
           { 97 },
           { 24 },
           { 12 },
           { 23 },
           { 85 },
           { 74 },
           { 51 },
           { 88 },
           { 92 },
        };

        [TestMethod]
        public void IsFirstTest1()
        {
            Assert.IsTrue(numbers.IsFirst(55));
        }

        [TestMethod]
        public void IsFirstTest2()
        {
            Assert.IsFalse(numbers.IsFirst(12));
        }

        [TestMethod]
        public void IsLastTest1()
        {
            Assert.IsTrue(numbers.IsLast(92));
        }

        [TestMethod]
        public void IsLastTest2()
        {
            Assert.IsFalse(numbers.IsLast(88));
        }
    }
}
