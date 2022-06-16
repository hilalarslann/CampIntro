using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();

        public void Add(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                this.customers.Add(customer);
            }
        }

        public void List()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void Delete(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                this.customers.Remove(customer);
            }
        }
    }
}
