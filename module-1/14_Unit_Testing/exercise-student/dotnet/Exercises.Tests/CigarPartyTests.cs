using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        Exercises.CigarParty cigarParty = new CigarParty();
        [TestMethod]
        public void TooFewCigarsReturnsFalse()
        {
            bool actual = cigarParty.HaveParty(30, false);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void MediumCigarsWeekdayReturnsTrue()
        {
            bool actual = cigarParty.HaveParty(50, false);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void ManyCigarsWeekendReturnsTrue()
        {
            bool actual = cigarParty.HaveParty(70, true);
            Assert.AreEqual(true, actual);
        }
    }
}
