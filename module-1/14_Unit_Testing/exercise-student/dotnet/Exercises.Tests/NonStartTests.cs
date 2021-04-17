using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        Exercises.NonStart nonStart = new NonStart();
        [TestMethod]
        public void IgnoreFirstLetterFiveLetters()
        {
            string result = nonStart.GetPartialString("Hello", "Brian");
            Assert.AreEqual("ellorian", result);
        }
        [TestMethod]
        public void IgnoreFirstLetterFourLetters()
        {
            string result = nonStart.GetPartialString("Java", "Code");
            Assert.AreEqual("avaode", result);
        }
        [TestMethod]
        public void IgnoreFirstLetterUnevenLetters()
        {
            string result = nonStart.GetPartialString("Shotl", "Java");
            Assert.AreEqual("hotlava", result);
        }
    }
}
