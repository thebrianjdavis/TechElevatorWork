using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        Exercises.DateFashion dateFashion = new DateFashion();
        [TestMethod]
        public void DateIsVeryHot()
        {
            int result = dateFashion.GetATable(5, 10);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void BothAreMeh()
        {
            int result = dateFashion.GetATable(5, 5);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void IAmUgly()
        {
            int result = dateFashion.GetATable(2, 5);
            Assert.AreEqual(0, result);
        }
    }
}
