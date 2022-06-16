using System;
using System.Collections.Generic;

namespace Deneme
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();
        List<Product> basketList = new List<Product>();

        public void AddCustomer(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                customerList.Add(customer);
            }
        }

        public void AddBasket(Product products)
        {
            basketList.Add(products);
        }

        public void MyBasketList()
        {
            foreach (Product item in basketList)
            {
                Console.WriteLine("Ürün adı : " + item.ProductName);
            }
        }
    }
}
