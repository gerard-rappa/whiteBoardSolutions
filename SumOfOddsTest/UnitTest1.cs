using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdds;

namespace SumOfOddsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, Program.SumOfOdds(10));
        }
        [TestMethod]
        public void TestMethod2()//should fail
        {
            //Assert.AreEqual(11, Program.SumOfOdds(10));
        }
        [TestMethod]
        public void TestMethod3()//should fail
        {
            //Assert.AreEqual(11, Program.SumOfOdds(12));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(11, Program.SumOfOdds(11));
        }
    }
}
