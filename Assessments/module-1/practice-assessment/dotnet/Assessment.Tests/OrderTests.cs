using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void StandardBouquetCost()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 0);

            decimal checkValue = 19.99M;
            decimal testValue = flowerShopOrder.Subtotal;

            Assert.AreEqual(checkValue, testValue);
        }
        [TestMethod]
        public void UpgradeBouquetCost()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 3);

            decimal checkValue = 28.96M;
            decimal testValue = flowerShopOrder.Subtotal;

            Assert.AreEqual(checkValue, testValue);
        }
        [TestMethod]
        public void LocalShippingNoCost()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 0);

            decimal checkValue = 0;
            decimal testValue = flowerShopOrder.DeliveryTotal(false, "10005");

            Assert.AreEqual(checkValue, testValue);
        }
        [TestMethod]
        public void SameDayShippingLocal()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 0);

            decimal checkValue = 5.99M;
            decimal testValue = flowerShopOrder.DeliveryTotal(true, "10005");

            Assert.AreEqual(checkValue, testValue);
        }
        [TestMethod]
        public void AnotherZipCodeNoSameDay()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 0);

            decimal checkValue = 6.99M;
            decimal testValue = flowerShopOrder.DeliveryTotal(false, "33559");

            Assert.AreEqual(checkValue, testValue);
        }
        [TestMethod]
        public void AnotherZipCodeWithSameDay()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 0);

            decimal checkValue = 9.98M;
            decimal testValue = flowerShopOrder.DeliveryTotal(true, "28478");

            Assert.AreEqual(checkValue, testValue);
        }
        [TestMethod]
        public void NonLocalZipCode()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 0);

            decimal checkValue = 19.99M;
            decimal testValue = flowerShopOrder.DeliveryTotal(false, "99999");

            Assert.AreEqual(checkValue, testValue);
        }
        [TestMethod]
        public void NonLocalZipCodeTrySameDay()
        {
            FlowerShopOrder flowerShopOrder = new FlowerShopOrder("standard", 0);

            decimal checkValue = 19.99M;
            decimal testValue = flowerShopOrder.DeliveryTotal(true, "99999");

            Assert.AreEqual(checkValue, testValue);
        }
    }
}
