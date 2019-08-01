using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JulianDate{
    [TestClass]
    public class UnitTest1{
        [TestMethod]
        public void Jan1(){
            Assert.AreEqual(1, Program.getJulian(1, 1));
        }
        [TestMethod]
        public void Dec31(){
            Assert.AreEqual(365, Program.getJulian(12, 31));
        }
        [TestMethod]
        public void MonthOver12(){
            Assert.AreEqual(0, Program.getJulian(16, 4));
        }
        [TestMethod]
        public void DayOver31(){
            Assert.AreEqual(0, Program.getJulian(11, 45));
        }
        [TestMethod]
        public void Feb30(){
            Assert.AreEqual(0, Program.getJulian(2, 30));
        }
        [TestMethod]
        public void Nov7(){
            Assert.AreEqual(311, Program.getJulian(11, 7));
        }
    }
}
