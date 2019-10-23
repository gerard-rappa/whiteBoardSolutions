using System;
using Acronym;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcronymTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void normalString()
        {
            Assert.AreEqual("TIANS", Program.GetAcronym("This is a normal sentence."));
        }
        [TestMethod]
        public void blankString()
        {
            Assert.AreEqual("", Program.GetAcronym(""));
        }
        [TestMethod]
        public void manySpaces()
        {
            Assert.AreEqual("LOS", Program.GetAcronym("  LoTS of       spaCes       "));
        }
    }
}
