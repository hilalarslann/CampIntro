using MakeDictionary;
using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Ali");
            myDictionary.Add(2, "Sevgi");

            myDictionary.ShowDictionary();

            Console.ReadLine();
        }
    }
}
