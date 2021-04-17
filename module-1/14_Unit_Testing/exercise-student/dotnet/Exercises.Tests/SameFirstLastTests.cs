using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        Exercises.SameFirstLast sameFirstLast = new SameFirstLast();
        [TestMethod]
        public void LengthThreeSameFalse()
        {
            int[] nums = new int[] { 1, 2, 3 };
            bool result = sameFirstLast.IsItTheSame(nums);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void LengthThreeSameTrue()
        {
            int[] nums = new int[] { 1, 2, 1 };
            bool result = sameFirstLast.IsItTheSame(nums);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LengthFiveSameTrue()
        {
            int[] nums = new int[] { 4, 3, 2, 1, 4 };
            bool result = sameFirstLast.IsItTheSame(nums);
            Assert.AreEqual(true, result);
        }
    }
}
