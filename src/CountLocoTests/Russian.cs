namespace CountLocoTests
{
    using System.Globalization;
    using System.Threading;
    using CountLoco;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Russian
    {
        [ClassInitialize]
        public static void InitializeLanguage(TestContext context)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
        }

        [TestMethod]
        public void TestRussian0()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         0.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("0 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian1()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         1.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("1 вещь", formattedString);
        }

        [TestMethod]
        public void TestRussian2()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         2.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("2 вещи", formattedString);
        }

        [TestMethod]
        public void TestRussian3()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         3.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("3 вещи", formattedString);
        }

        [TestMethod]
        public void TestRussian4()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         4.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("4 вещи", formattedString);
        }

        [TestMethod]
        public void TestRussian5()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         5.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("5 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian6()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         6.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("6 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian7()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         7.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("7 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian8()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         8.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("8 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian9()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         9.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("9 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian11()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         11.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("11 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian15()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         15.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("15 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian21()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         21.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("21 вещь", formattedString);
        }

        [TestMethod]
        public void TestRussian22()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         22.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("22 вещи", formattedString);
        }

        [TestMethod]
        public void TestRussian29()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         29.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("29 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian100()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         100.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("100 вещей", formattedString);
        }

        [TestMethod]
        public void TestRussian1001()
        {
            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things,
                                                                         1001.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("1001 вещь", formattedString);
        }
    }
}
