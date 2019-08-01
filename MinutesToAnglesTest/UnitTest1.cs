using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace minutesToAngles
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Program.clockAngle(12, 0));            
        }
        [TestMethod]
        public void TestMethod2()
        {
           Assert.AreEqual(102, Program.clockAngle(12, 17));            
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(180, Program.clockAngle(6, 0));
        }
    }
}
