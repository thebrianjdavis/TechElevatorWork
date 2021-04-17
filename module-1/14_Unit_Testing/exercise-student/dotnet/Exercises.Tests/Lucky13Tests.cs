using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        Exercises.Lucky13 lucky13 = new Lucky13();
        [TestMethod]
        public void NoOnesOrThreesReturnsTrue()
        {
            int[] nums = new int[] { 0, 2, 4 };
            bool result = lucky13.GetLucky(nums);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ThreeReturnsFalse()
        {
            int[] nums = new int[] { 3, 2, 4 };
            bool result = lucky13.GetLucky(nums);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void OneReturnsFalse()
        {
            int[] nums = new int[] { 1, 2, 4 };
            bool result = lucky13.GetLucky(nums);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void OnesAndThreesReturnsFalse()
        {
            int[] nums = new int[] { 1, 2, 3 };
            bool result = lucky13.GetLucky(nums);
            Assert.AreEqual(false, result);
        }
    }
}
