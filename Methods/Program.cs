using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explain = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explain = "Diyarbakır watermelon ";

            Product[] products = new Product[] {product1, product2};

            //type-safe
            foreach (Product product in products)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explain);
            }

            Console.WriteLine("-------------Methods--------------");

            //instance
            //encapsulation

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            //Yanlış kullanım
            basketManager.Add2("Pear", "Green Apple", 12);
            basketManager.Add2("Apple", "Green Apple", 12);
            basketManager.Add2("Melon",  "Green Apple", 12);

            Console.ReadLine();
        }
    }
}
 
//Do not repeat yourself - DRY - Clean Code - Best Practice 