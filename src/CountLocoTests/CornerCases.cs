namespace CountLocoTests
{
    using System;
    using System.Globalization;
    using CountLoco;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CornerCases
    {
        [TestMethod]
        public void Test0LengthNumber()
        {
            string formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things, string.Empty);
            Assert.IsTrue(formattedString == string.Empty);
        }

        [TestMethod]
        public void Test0LengthFormat()
        {
            string formattedString = Pluralizer.GetFormattedStringForNumber(string.Empty, string.Empty);
            Assert.IsTrue(formattedString == string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "number")]
        public void TestNullNumber()
        {
            Pluralizer.GetFormattedStringForNumber(Strings.Things, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "format")]
        public void TestNullFormat()
        {
            Pluralizer.GetFormattedStringForNumber(null, string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "format")]
        public void TestFormatWithNoPair()
        {
            Pluralizer.GetFormattedStringForNumber("this is a string that has no 'equals' sign", 6.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void TestFormatWithNoNumber()
        {
            string formattedString = Pluralizer.GetFormattedStringForNumber("|||6=blah", 6.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("blah", formattedString);
        }

        [TestMethod]
        public void TestUndefinedFormat()
        {
            string formattedString = Pluralizer.GetFormattedStringForNumber("|||5={0}", 6.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("UNDEFINED", formattedString);
        }
    }
}
