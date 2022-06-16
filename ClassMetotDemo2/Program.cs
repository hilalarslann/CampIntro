using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Hilal", "Arslan", 90);
            Customer customer2 = new Customer(1, "Sümeyye", "Arslan", 90);
            Customer customer3 = new Customer(1, "Ömer", "Arslan", 90);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1, customer2, customer3);
            customerManager.List();
            customerManager.Delete(customer1);
            customerManager.List();

            Console.ReadLine();
        }
    }
}
