using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        Exercises.Less20 less20 = new Less20();
        [TestMethod]
        public void WithinTwo18()
        {
            bool result = less20.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void WithinTwo19()
        {
            bool result = less20.IsLessThanMultipleOf20(19);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void WithinTwo40()
        {
            bool result = less20.IsLessThanMultipleOf20(40);
            Assert.AreEqual(false, result);
        }
    }
}
