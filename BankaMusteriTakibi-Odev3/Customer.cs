using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer(int id, string name, string surname)
        {
            ID = id;
            Name = name;
            Surname = surname;
        }
    }
}
