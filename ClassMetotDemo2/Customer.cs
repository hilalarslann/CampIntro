using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Point { get; set; }

        public Customer(int ID, string name, string surname, int point)
        {
            this.ID = ID;
            Name = name;
            Surname = surname;
            Point = point;
        }
    }
}
