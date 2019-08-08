using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumbers;

namespace PrimeNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void zero()
        {
            Assert.AreEqual(false, PrimeNumbers.Program.isPrime(0));
        }
        [TestMethod]
        public void negative()
        {
            Assert.AreEqual(false, PrimeNumbers.Program.isPrime(-10));
        }
        [TestMethod]
        public void two()
        {
            Assert.AreEqual(true, PrimeNumbers.Program.isPrime(2));
        }
        [TestMethod]
        public void largePrime()
        {
            Assert.AreEqual(true, PrimeNumbers.Program.isPrime(13441));
        }
    }
}
