using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueChars;

namespace UniqueCharsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void normalString()
        {
            Assert.AreEqual(5, Program.UniqueChars("AbcCd"));
        }
        [TestMethod]
        public void blankString()
        {
            Assert.AreEqual(0, Program.UniqueChars(""));
        }
        [TestMethod]
        public void manySpaces()
        {
            Assert.AreEqual(1, Program.UniqueChars("   f       "));
        }
    }
}
