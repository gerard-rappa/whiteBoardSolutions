using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString;

namespace ReverseStringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void noChars()
        {
            Assert.AreEqual("", Program.reverseString(""));
        }

        [TestMethod]
        public void oneChars()
        {
            Assert.AreEqual("a", Program.reverseString("a"));
        }

        [TestMethod]
        public void normalCase()
        {
            Assert.AreEqual("appaR drareG", Program.reverseString("Gerard Rappa"));
        }

        [TestMethod]
        public void nullCase()
        {
            Assert.AreEqual(null, Program.reverseString(null));
        }
    }
}
