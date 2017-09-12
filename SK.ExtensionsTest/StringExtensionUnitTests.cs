﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SK.CSharpExtensions;

namespace SK.ExtensionsTest
{
    [TestClass]
    public class StringExtensionUnitTests
    {
        [TestMethod]
        public void ToTitleCaseTest1()
        {
            string str = "sample test string.";
            var result = str.ToTitleCase();
            Assert.AreEqual("Sample Test String.", result);
        }

        [TestMethod]
        public void ToTitleCaseTest2()
        {
            string str = "SAMPLE TEST STRING.";
            var result = str.ToTitleCase();
            Assert.AreEqual("Sample Test String.", result);
        }

        [TestMethod]
        public void ToTitleCaseTest3()
        {
            string str = "sample TEST stRing.";
            var result = str.ToTitleCase();
            Assert.AreEqual("Sample Test String.", result);
        }

        [TestMethod]
        public void IsNumericTest1()
        {
            string str = "0123";
            var result = str.IsNumeric();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumericTest2()
        {
            string str = "-0.123";
            var result = str.IsNumeric();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumericTest3()
        {
            string str = "abcd";
            var result = str.IsNumeric();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CamelCaseToHumanReadableStringTest1()
        {
            string str = "SampleTestString";
            var result = str.CamelCaseToHumanReadableString();
            Assert.AreEqual("Sample Test String", result);
        }

        [TestMethod]
        public void CamelCaseToHumanReadableStringTest2()
        {
            string str = "SAMPLETestString";
            var result = str.CamelCaseToHumanReadableString();
            Assert.AreEqual("SAMPLE Test String", result);
        }

        [TestMethod]
        public void CamelCaseToHumanReadableStringTest3()
        {
            string str = "SAMPLETestSTRING";
            var result = str.CamelCaseToHumanReadableString();
            Assert.AreEqual("SAMPLE Test STRING", result);
        }

        [TestMethod]
        public void ToCleanStringTest1()
        {
            string str = "This is a   sample \ntest string \r\n Another  line of    text.";
            var result = str.ToCleanString();
            Assert.AreEqual("This is a sample test string Another line of text.", result);
        }

    }
}
