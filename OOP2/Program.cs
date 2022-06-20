using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hilal Arslan
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Hilal";
            customer1.LastName = "Arslan";
            customer1.TcNumber = "216354584222";

            //Roya Silver
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Roya Silver";
            customer2.TaxNumber = "1234567890";

            //Müşteri classı hem gerçek kişinin referansını tutabiliyor hemde tüzel müşterinin referansını tutabiliyor.
            //Base sınıfımız referans tutucudur.
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer3);

            Console.ReadLine();
        }
    }
}
