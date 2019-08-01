using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountCapitals;

namespace CountCapitalsTest{
    [TestClass]
    public class UnitTest1{
        [TestMethod]
        public void TestMethod1(){
            Assert.AreEqual(0, Program.CountCapitals("hello 1 23"));
            Assert.AreEqual(0, Program.CountCapitals(""));
            Assert.AreEqual(4, Program.CountCapitals("hELLO 1 23     "));
            Assert.AreEqual(3, Program.CountCapitals("ALL"));
        }
    }
}
