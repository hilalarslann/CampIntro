using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Hilal", "Arslan");
            Customer customer2 = new Customer(2, "Ali", "Kul");
            Customer customer3 = new Customer(3, "Zeynep", "Serengil");
            Customer customer4 = new Customer(4, "Zeki", "Abidin");

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1, customer2, customer3, customer4);
            customerManager.List();
            customerManager.Delete(customer4);
            Console.WriteLine("");
            customerManager.List();

            Console.ReadLine();
        }
    }
}
