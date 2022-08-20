using System;
using System.Collections.Generic;
using static VendingMachine.Models.Product;

namespace VendingMachine.Models
{
    public interface IVendingMachineHelper
    {
        List<Product> Products { get; set; }

        double GetProductPrice(ProductList Name);
    }
}