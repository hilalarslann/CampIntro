using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type-int, decimal, float, enum, boolean
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;

            Console.WriteLine("Number1 : " + number1);
            //number1 - 30

            //Reference Type-arrays, class, string, interface..
            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;

            Console.WriteLine("Numbers1[0] : " + numbers1[0]);
            //numbers1[0] - 999
            Console.ReadLine(); 
        }
    }
}
