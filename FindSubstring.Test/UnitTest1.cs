using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindSubstring;

namespace FindSubstringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(-1, Program.IndexOfSubstring("Mississippi", null));
            Assert.AreEqual(-1, Program.IndexOfSubstring("Mississippi", ""));
            Assert.AreEqual(0, Program.IndexOfSubstring("Mississippi", "Mississippi"));
            Assert.AreEqual(4, Program.IndexOfSubstring("Mississippi", "issip"));
            Assert.AreEqual(-1, Program.IndexOfSubstring(null,""));

        }
    }
}
