using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTranslate.Models;

namespace NumberTranslate.Test
{
    [TestClass]
    public class TranslateTest
    {
        [TestMethod]
        public void NumberTranslator_TurnsNumericFormIntoString_Five()
        {
            int userNumber = 5;
            Translate newTranslation = new Translate(userNumber);
            newTranslation.ConvertNumber();
            string result = newTranslation.StringOutput;
            Assert.AreEqual("five", result);
        }
    }
}