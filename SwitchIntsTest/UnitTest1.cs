using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwitchInts;

namespace SwitchIntsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("0, 12", Program.switchInts(12, 0));
        }

        [TestMethod]
        public void normal()
        {
            Assert.AreEqual("0, 12", Program.switchInts(12, 0));
        }

        [TestMethod]
        public void equal()
        {
            Assert.AreEqual("0, 0", Program.switchInts(0, 0));
        }

        [TestMethod]
        public void negative()
        {
            Assert.AreEqual("0, -12", Program.switchInts(-12, 0));
        }

        [TestMethod]
        public void twoNegatives()
        {
            Assert.AreEqual("-100, -12", Program.switchInts(-12, -100));
        }
    }
}
