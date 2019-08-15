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
            Assert.IsFalse(PrimeNumbers.Program.isPrime(0));
        }
        [TestMethod]
        public void negative()
        {
            Assert.IsFalse(PrimeNumbers.Program.isPrime(-10));
        }
        [TestMethod]
        public void two()
        {
            Assert.IsTrue(PrimeNumbers.Program.isPrime(2));
        }
        [TestMethod]
        public void largePrime()
        {
            Assert.IsTrue(PrimeNumbers.Program.isPrime(13441));
        }
    }
}
