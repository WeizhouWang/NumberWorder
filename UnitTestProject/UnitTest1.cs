using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberWorder;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertNumberToWord_Pass()
        {
            var result = Program.ConvertNumberToWord("1234");
            Assert.AreEqual(result, "ONETWOTHREEFOUR");
        }

        [TestMethod]
        public void ConvertNumberToWord_InvalidCharacter()
        {
            var result = Program.ConvertNumberToWord("1234a");
            Assert.AreEqual(result, null);
        }
    }
}
