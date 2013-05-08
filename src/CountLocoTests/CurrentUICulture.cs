namespace CountLocoTests
{
    using System.Globalization;
    using System.Threading;
    using CountLoco;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CurrentUICulture
    {
        [TestMethod]
        public void Test0In2Languages()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            string zero = "0";

            var formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things, zero);
            Assert.AreEqual("0 things", formattedString);

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            formattedString = Pluralizer.GetFormattedStringForNumber(Strings.Things, zero);
            Assert.AreEqual("0 вещей", formattedString);
        }
    }
}
