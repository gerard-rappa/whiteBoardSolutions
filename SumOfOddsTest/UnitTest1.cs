using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdds;

namespace SumOfOddsTest{
    [TestClass]
    public class UnitTest1{
        [TestMethod]
        public void odd(){
            Assert.AreEqual(9, Program.SumOfOdds(5));
        }
        [TestMethod]
        public void zero(){
            Assert.AreEqual(0, Program.SumOfOdds(0));
        }
        [TestMethod]
        public void even(){
            Assert.AreEqual(25, Program.SumOfOdds(10));
        }
        [TestMethod]
        public void one(){
            Assert.AreEqual(1, Program.SumOfOdds(1));
        }
    }
}
