using BonusApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Bonuses _bonus = new Bonuses();
        private readonly Order _order = new Order();
        [TestInitialize]
        public void Init()
        {
            Product pro1 = new Product("bil", 10.0);
            Product pro2 = new Product("toy", 10.0);
            Product pro3 = new Product("tog", 10.0);
            Product pro4 = new Product("ske", 10.0);
            Product pro5 = new Product("kop", 10.0);

            _order.AddProduct(pro1);
            _order.AddProduct(pro2);
            _order.AddProduct(pro3);
            _order.AddProduct(pro4);
            _order.AddProduct(pro5);
        }
        [TestMethod]
        public void TenPercent_Test()
        {   
            Assert.AreEqual(10.01, _bonus.TenPercent(100.100));
            Assert.AreEqual(10.05, _bonus.TenPercent(100.50));
        }

        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, _bonus.FlatTwoIfAmountMoreThanFive(10));
            Assert.AreEqual(0.0, _bonus.FlatTwoIfAmountMoreThanFive(4));
        }
        [TestMethod]
        public void GetValueOfProducts_Test()
        {   
            Assert.AreEqual(50.0, _order.GetValueOfProduct());
        }
        [TestMethod]
        public void GetBonus_Test()
        {
            Assert.AreEqual(15.0, _order.GetBonus());
        }
        [TestMethod]
        public void GetTotalPrice_Test()
        {
            Assert.AreEqual(35.0, _order.GetTotalprice());
        }
    }
}
