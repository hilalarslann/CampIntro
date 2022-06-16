using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //Primary key
        public int Id { get; set; }
        //Foreign key 
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //birimfiyat
        public int UnitsInStock { get; set; } 
    }
}
