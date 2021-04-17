using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        Exercises.AnimalGroupName animalGroupName = new AnimalGroupName();
        [TestMethod]
        public void TestAnimalGroupName()
        {
            string actual = animalGroupName.GetHerd("Giraffe");
            Assert.AreEqual("Tower", actual);
        }
        [TestMethod]
        public void SearchNotUppercaseSensitive()
        {
            string actual = animalGroupName.GetHerd("GIRAFFE");
            Assert.AreEqual("Tower", actual);
        }
        [TestMethod]
        public void SearchNotLowercaseSensitive()
        {
            string actual = animalGroupName.GetHerd("giraffe");
            Assert.AreEqual("Tower", actual);
        }
        [TestMethod]
        public void NothingReturnsUnknown()
        {
            string actual = animalGroupName.GetHerd("");
            Assert.AreEqual("unknown", actual);
        }
        [TestMethod]
        public void NotListedReturnsUnknown()
        {
            string actual = animalGroupName.GetHerd("aliens");
            Assert.AreEqual("unknown", actual);
        }
    }
}
