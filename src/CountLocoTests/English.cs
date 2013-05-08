using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountLocoTests
{
    using System.Globalization;
    using System.Threading;
    using CountLoco;

    [TestClass]
    public class English
    {
        [ClassInitialize]
        public static void InitializeLanguage(TestContext context)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        [TestMethod]
        public void TestEnglish0()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         0.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("0 things", formattedString);
        }

        [TestMethod]
        public void TestEnglish1()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         1.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("1 thing", formattedString);
        }

        [TestMethod]
        public void TestEnglish2()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         2.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("2 things", formattedString);
        }

        [TestMethod]
        public void TestEnglish21()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         21.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("21 things", formattedString);
        }

        [TestMethod]
        public void TestEnglish100()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         100.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("100 things", formattedString);
        }
    }
}