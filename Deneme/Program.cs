using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Person person1 = customer1;

            Clothes clothes1 = new Clothes();
            Shoes shoes1 = new Shoes();

            Product product1 = shoes1;
            product1.ProductName = "Ayakkabı";
            product1.Seller = "Trendyolmilla";
            product1.UnitPrice = 150;

            Product product2 = clothes1;
            product2.ProductName = "Tişört";
            product2.Seller = "Trendyolmilla";
            product2.UnitPrice = 89;

            PersonManager customerManager = new PersonManager();
            ProductManager productManager = new ProductManager();

            productManager.AddProduct(clothes1);
            productManager.ProductList();

            customerManager.AddPerson(customer1);
            customer1.AddBasket(shoes1);
            customer1.AddBasket(clothes1);
            customer1.MyBasketList();


            Console.ReadLine();
        }
    }
}
