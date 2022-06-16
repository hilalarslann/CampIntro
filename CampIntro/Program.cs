using System;

namespace CampIntro
{
    class Program
    {
        static bool checkOnline = false;

        static void Main(string[] args)
        {
            Sign("a", "2sd");

            if (checkOnline)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.ReadLine();

        } 

        static void Sign(string userName, string pasw)
        {
            if (userName == "a" && pasw == "2sd")
            {
                Console.WriteLine("Giriş sayfasına yönlendir");
                checkOnline = true;
            }
            else
            {
                Console.WriteLine("Girilen bilgiler hatalı");
            }
        }

    }
}
