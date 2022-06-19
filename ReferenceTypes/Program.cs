using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            Person person1 = customer1;
            person1.FirstName = "Hilal";
            Console.WriteLine(((Customer)person1).CreditCardNumber = "1542 8547 2485 5248");

            PersonManager personManager = new PersonManager();

            personManager.Add(customer1);

            Console.ReadLine();
        }
    }

    //base class
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " " + "Eklendi");
        }
    }
}
