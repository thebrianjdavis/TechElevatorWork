using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        Exercises.MaxEnd3 maxEnd3 = new MaxEnd3();
        [TestMethod]
        public void FirstNumberBiggest()
        {
            int[] testArray = new int[] { 11, 5, 9 };
            int[] repeat11s = new int[] { 11, 11, 11 };
            int[] result = maxEnd3.MakeArray(testArray);
            CollectionAssert.AreEqual(repeat11s, result);
        }
        [TestMethod]
        public void LastNumberBiggest()
        {
            int[] testArray = new int[] { 3, 5, 9 };
            int[] repeat9s = new int[] { 9, 9, 9 };
            int[] result = maxEnd3.MakeArray(testArray);
            CollectionAssert.AreEqual(repeat9s, result);
        }
        [TestMethod]
        public void IgnoreMiddleNumber()
        {
            int[] testArray = new int[] { 1, 8, 3 };
            int[] repeat3s = new int[] { 3, 3, 3 };
            int[] result = maxEnd3.MakeArray(testArray);
            CollectionAssert.AreEqual(repeat3s, result);
        }
    }
}
