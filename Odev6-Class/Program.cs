using System;

namespace Odev6_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productID = "TWOSS22SR00159";
            product1.productName = "Bej Belden Bağlamalı Keten Görünümlü Denim Şort Etek";
            product1.basketPrice = 183.99;
            product1.point = 4;
            product1.brand = "TRENDYOLMİLLA";

            Product product2 = new Product();
            product2.productID = "TWOSS22SR00158";
            product2.productName = "Taş Bürümcük Fitted Örme Atlet";
            product2.basketPrice = 71.99;
            product2.point = 5;
            product2.brand = "TRENDYOLMİLLA";

            Product[] products = { product1, product2 };

            Console.WriteLine("With for");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName);
            }

            Console.WriteLine("With foreach");
            foreach (var product in products)
            {
                Console.WriteLine(product.productName);
            }

            Console.WriteLine("With while");
            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine(products[x].productName);
                x++;
            }
            Console.ReadLine();

        }
    }

    class Product
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public double basketPrice { get; set; }
        public int point { get; set; }
        public string brand { get; set; }
    }
}
