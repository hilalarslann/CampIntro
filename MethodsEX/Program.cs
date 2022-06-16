using System;
using System.Linq;

namespace MethodsEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add4(2,5,4));

            Console.ReadLine();
        }

        static int Add4(int number1, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
