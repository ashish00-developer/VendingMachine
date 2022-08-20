using System.Collections.Generic;
using static VendingMachine.Models.Product;

namespace VendingMachine.Models
{
    public class VendingMachineHelper:IVendingMachineHelper
    {
        public List<Product> Products { get; set; }

        public VendingMachineHelper()
        {
            Products = PopulateProducts();
        }
        public double GetProductPrice(ProductList Name)
        {
            double price;
            switch (Name)
            {
                case ProductList.Cola:
                    price = 1.0;
                    break;
                case ProductList.Chips:
                    price = 0.50;
                    break;
                default:
                    price = 0.65;
                    break;
            }
            return price;
        }

        public static List<Product> PopulateProducts()
        {
            return new List<Product>()
            {
                new Product("Cola", 1.0),
                new Product("Chips", 0.50),
                 new Product("Candy", 0.65)
            };
        }


    }
}