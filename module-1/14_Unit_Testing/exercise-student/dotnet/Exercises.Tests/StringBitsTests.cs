using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        Exercises.StringBits stringBits = new StringBits();
        [TestMethod]
        public void AlternateFromFive()
        {
            string result = stringBits.GetBits("Hello");
            Assert.AreEqual("Hlo", result);
        }
        [TestMethod]
        public void AlternateFromTwo()
        {
            string result = stringBits.GetBits("Hi");
            Assert.AreEqual("H", result);
        }
        [TestMethod]
        public void AlternateFromNine()
        {
            string result = stringBits.GetBits("Heeololeo");
            Assert.AreEqual("Hello", result);
        }
    }
}
