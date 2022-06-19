using MakeDictionary;
using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        //static Dictionary<int, Customer> customerDicList = new Dictionary<int, Customer>();

        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Ali");
            myDictionary.Add(2, "Sevgi");

            myDictionary.ShowDictionary();

            //customerDicList.Add(1, new Customer() { Name = "Hilal Arslan" });
            //customerDicList.Add(2, new Customer() { Name = "Ömer Bulanık" });
            //customerDicList.Add(3, new Customer() { Name = "Kemal Sunal" });

            //Console.WriteLine(customerDicList.ContainsKey(1) ? "Eleman var: " + customerDicList[1].Name : "Eleman yok");

            //Console.WriteLine(FindList(3));
            //Console.WriteLine(FindList(5));

            Console.ReadLine();
        }

        //public static string FindList(int searchWorld)
        //{
        //    Customer returnValue;
        //    if (customerDicList.TryGetValue(searchWorld, out returnValue))
        //    {
        //        return "Eleman var: " + returnValue.Name;
        //    }
        //    else
        //    {
        //        return "Listede bu müşteri yok";
        //    }
        //}

        //class Customer
        //{
        //    public string Name { get; set; }
        //}
    }
}
