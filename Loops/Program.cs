using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Courses = new string[] {"Yazılım Geliştirme Kampı", "Programlamaya Giriş için Temel Kurs", "Java" };

            for (int i = 0; i < Courses.Length; i++)
            {
                Console.WriteLine(Courses[i]);
            }

            //dizi temelli yapıları tek tek dönmeye yarar.
            foreach (var course in Courses)
            {
                Console.WriteLine(course);
            }

            Console.ReadLine();
        }
    }
}
