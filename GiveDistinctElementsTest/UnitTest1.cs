using Microsoft.VisualStudio.TestTools.UnitTesting;
using GiveDistinctCount;

namespace GiveDistinctElementsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void one()
        {
            int[] array = { 1 };
            Assert.AreEqual(1, GiveDistinctCount.GiveDistinctCount.getDistinctCount(array));
        }

        [TestMethod]
        public void two()
        {
            int[] array = { 1, 2 };
            Assert.AreEqual(2, GiveDistinctCount.GiveDistinctCount.getDistinctCount(array));
        }

        [TestMethod]
        public void three()
        {
            int[] array = { 1, 2, 3, 3, 3, 3, 3 };
            Assert.AreEqual(3, GiveDistinctCount.GiveDistinctCount.getDistinctCount(array));
        }

        [TestMethod]
        public void zero()
        {
            int[] array = { };
            Assert.AreEqual(0, GiveDistinctCount.GiveDistinctCount.getDistinctCount(array));
        }

        [TestMethod]
        public void random()
        {
            int[] array = { 1,7,4,3,7,3,54,61,1,7 };
            Assert.AreEqual(6, GiveDistinctCount.GiveDistinctCount.getDistinctCount(array));
        }
    }
}
