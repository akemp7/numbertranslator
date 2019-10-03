using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTranslate.Models;

namespace NumberTranslate.Test
{
    [TestClass]
    public class TranslateTest
    {
        [TestMethod]
        public void NumberTranslator_TurnsSingleDigitsIntoString_Five()
        {
            string userNumber = "5";
            Translate newTranslation = new Translate(userNumber);
            newTranslation.ConvertNumber();
            string result = newTranslation.StringOutput;
            Assert.AreEqual("five", result);
        }

        [TestMethod]
        public void NumberTranslator_TurnsTwoDigitsIntoString_TwentyFive()
        {
            string userNumber = "25";
            Translate newTranslation = new Translate(userNumber);
            newTranslation.ConvertNumber();
            string result = newTranslation.StringOutput;
            Assert.AreEqual("twenty five", result);
        }
    }
}