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
            Assert.AreEqual("   five", result);
        }

        [TestMethod]
        public void NumberTranslator_TurnsTwoDigitsIntoString_SixtyEight()
        {
            string userNumber = "68";
            Translate newTranslation = new Translate(userNumber);
            newTranslation.ConvertNumber();
            string result = newTranslation.StringOutput;
            Assert.AreEqual("  sixty eight", result);
        }

        [TestMethod]
        public void NumberTranslator_TurnsThreeDigitsIntoString_OnehundredFifteen()
        {
            string userNumber = "115";
            Translate newTranslation = new Translate(userNumber);
            newTranslation.ConvertNumber();
            string result = newTranslation.StringOutput;
            Assert.AreEqual(" one hundred fifteen ", result);
        }

         [TestMethod]
        public void NumberTranslator_TurnsFourDigitsIntoString_SixThousandFour()
        {
            string userNumber = "6004";
            Translate newTranslation = new Translate(userNumber);
            newTranslation.ConvertNumber();
            string result = newTranslation.StringOutput;
            Assert.AreEqual("six thousand   four", result);
        }
    }
}