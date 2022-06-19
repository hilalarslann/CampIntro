using System;
using System.Collections.Generic;

namespace Deneme
{
    class ProductManager
    {
        List<Product> productList = new List<Product>();

        public void AddProduct(params Product[] products)
        {
            foreach (Product product in products)
            {
                productList.Add(product);
            }
        }

        public void ProductList()
        {
            foreach (var item in productList)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
