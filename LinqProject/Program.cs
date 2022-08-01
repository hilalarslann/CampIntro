using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId =1, CategoryName="Bilgisayar"},
                new Category { CategoryId = 2, CategoryName = "Telefon" }
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop",
                    QuantityPerUnit = "16 GB Ram", UnitInStock = 5, UnitPrice = 50000},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Monster Laptop",
                    QuantityPerUnit = "32 GB Ram", UnitInStock = 5, UnitPrice = 30000},
                new Product{ProductId = 3, CategoryId = 2, ProductName = "Samsung Telefon",
                    QuantityPerUnit = "32 GB Ram", UnitInStock = 5, UnitPrice = 4000}

            };

            foreach (var p in GetProducts(products))
            {
                Console.WriteLine(p.ProductName);
            }

            foreach (var p in GetProductsLinq(products))
            {
                Console.WriteLine(p.ProductName);
            }
        }

        //Linqsiz Kullanımı
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        //Linq ile Kullanımı
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        }
    }
}
