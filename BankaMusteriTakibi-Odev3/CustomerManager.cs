using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();

        public void Add(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                customerList.Add(customer); 
            }
        }

        public void List()
        {
            Console.WriteLine("-------------All Customer-----------");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void Delete(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                customerList.Remove(customer);
            }
        }
    }
}
