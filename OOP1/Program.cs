using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek hayatta ürünleri böyle ellerimizle girmiyoruz.Gerçek hayatta bu verileri kullanıcıdan alıyoruz.
            //Bunu bir Angular uygulaması ile kullanıcın bir ekran vasıtası ile alıyor olacağız.
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = " Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Console.ReadLine();
        }
    }
}
