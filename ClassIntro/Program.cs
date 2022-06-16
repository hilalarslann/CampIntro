using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
         //Kurs classımıza nesne oluşturup özelliklerini ekledik.
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demiroğ";
            course1.Rating = 85;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Hilal Arslan";
            course2.Rating = 95;

         //Kursların hepsini diziye atadık.
            Course[] courses = new Course[] {course1, course2};

         //Tüm kursların adını yazdırdık.
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " " + course.Instructor);
            }

            Console.ReadLine();
        }
    }


    //Kurs Classımız
    class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int Rating { get; set; }
    }
}
