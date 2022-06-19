using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, Name = "Selin", City = "İstanbul" };
            Customer customer2 = new Customer(1, "Asu", "Ankara");

            Console.ReadLine();
        }
    }
    class Customer
    {
        public Customer() { }
        public Customer(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
