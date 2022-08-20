using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VendingMachine.Models.Tests
{
    [TestClass()]
    public class VendingMachineTests
    {

        [TestMethod()]
        public void GetProductPriceTest()
        {
            VendingMachineHelper vendingMachineHelper = new VendingMachineHelper();
            Product.ProductList name = Product.ProductList.Cola;
            double price = 1.0;
            double result = 0.00;
            try
            {
                result = vendingMachineHelper.GetProductPrice(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual(result, price);
        }
    }
}