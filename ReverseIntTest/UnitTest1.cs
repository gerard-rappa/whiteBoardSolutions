using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInt;
namespace ReverseIntTest{
    [TestClass]
    public class UnitTest1{
        [TestMethod]
        public void one(){
            Assert.AreEqual(1, Program.reverseInt(1));
        }

        [TestMethod]
        public void zero(){
            Assert.AreEqual(0, Program.reverseInt(0));
        }
        [TestMethod]
        public void general(){
            Assert.AreEqual(321, Program.reverseInt(123));
        }
        [TestMethod]
        public void leadingZeros(){
            Assert.AreEqual(1, Program.reverseInt(001));
        }

        [TestMethod]
        public void trailingZeros(){
            Assert.AreEqual(1, Program.reverseInt(0000001));
        }

        [TestMethod]
        public void negative(){
            Assert.AreEqual(-655, Program.reverseInt(-556));
        }
    }
}
