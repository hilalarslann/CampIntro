using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Hilal Arslan");
            Customer customer2 = new Customer(2, "Ali Arslan");
            Customer customer3 = new Customer(3, "Sevil Arslan");

            Product product1 = new Product();
            product1.ProductName = "Ayakkabı";
            product1.Seller = "Trendyolmilla";
            product1.UnitPrice = 150;

            Product product2 = new Product();
            product2.ProductName = "Tişört";
            product2.Seller = "Trendyolmilla";
            product2.UnitPrice = 89;

            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();

            productManager.AddProduct(product1, product2);

            customerManager.AddCustomer(customer1, customer2, customer3);
            customer1.AddBasket(product1);
            customer1.AddBasket(product2);
            customer1.MyBasketList();


            Console.ReadLine();
        }
    }
}
