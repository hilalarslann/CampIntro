using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //naming convention
        //syntax

        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string explain, double price)
        {
            Console.WriteLine("Sepete eklendi : " + productName);
        }
    }
}
