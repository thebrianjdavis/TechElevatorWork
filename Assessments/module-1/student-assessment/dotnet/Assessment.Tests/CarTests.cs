using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class CarTests
    {
        Assessment.Car car = new Car(2009, "tC", false);
        [TestMethod]
        public void CarHasCorrectAge()
        {
            int ageCheck = 12;

            Assert.AreEqual(ageCheck, car.Age);
        }

        [TestMethod]
        public void EvenYearNotNeeded()
        {
            bool needCheck = false;
            bool carCheck = car.NeedsECheck(2020);

            Assert.AreEqual(needCheck, carCheck);
        }

        [TestMethod]
        public void OddYearIsNeeded()
        {
            bool needCheck = true;
            bool carCheck = car.NeedsECheck(2021);

            Assert.AreEqual(needCheck, carCheck);
        }
    }
}
