using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        Exercises.FrontTimes frontTimes = new FrontTimes();
        [TestMethod]
        public void RepeatsTwice()
        {
            string result = frontTimes.GenerateString("Chocolate", 2);
            Assert.AreEqual("ChoCho", result);
        }
        [TestMethod]
        public void RepeatsThrice()
        {
            string result = frontTimes.GenerateString("Chocolate", 3);
            Assert.AreEqual("ChoChoCho", result);
        }
        [TestMethod]
        public void RepeatsOnlyThreeChars()
        {
            string result = frontTimes.GenerateString("101", 4);
            Assert.AreEqual("101101101101", result);
        }
    }
}
