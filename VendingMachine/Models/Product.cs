using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachine.Models
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public enum ProductList
        {
            Cola,
            Chips,
            Candy
        }
    }
}