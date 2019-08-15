using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LetterCountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void one()
        {
            Assert.AreEqual(1, LetterCount.LetterCount.countLetters("a     "));
        }
        [TestMethod]
        public void two()
        {
            Assert.AreEqual(2, LetterCount.LetterCount.countLetters("a  v ...\n*&  "));
        }
        [TestMethod]
        public void zero()
        {
            Assert.AreEqual(0, LetterCount.LetterCount.countLetters("   ./*&^7644%&^$#  \n\n\t\n   "));
        }
        [TestMethod]
        public void normal()
        {
            Assert.AreEqual(40, LetterCount.LetterCount.countLetters("The quick brown fox jumps over the lazy brown dog."));
        }
    }
}
