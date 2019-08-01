using CamelCase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CamelCaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void blankString()
        {
            Assert.AreEqual("", Program.toCamel(""));
        }
        [TestMethod]
        public void singleChars()
        {
            Assert.AreEqual("aBC", Program.toCamel("     A                    b  c             "));
        }
        [TestMethod]
        public void words()
        {
            Assert.AreEqual("helloMyNameIsGerry", Program.toCamel("HELLO  mY NaMe is gerrY                       "));
        }
        [TestMethod]
        public void specialCharsOnly()
        {
            Assert.AreEqual("", Program.toCamel("!!!!$&^%$*&^(^$!!!!!"));
        }
        [TestMethod]
        public void charsSpecialsAndWords()
        {
            Assert.AreEqual("aBb", Program.toCamel("@@@a!!!!!!bb            "));
        }

        [TestMethod]
        public void veryStrangeChars()
        {
            Assert.AreEqual("aaBbCc", Program.toCamel("??????aa BB   ? cC"));
        }
    }
}