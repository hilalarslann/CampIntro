using System;
using System.Collections.Generic;
using System.Text;


namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oluşturduğumuz Generic yapılı classdan referans ürettik.
            MyList<string> names = new MyList<string>();
            names.Add("Engin");
            names.Add("Hilal");

            //Listedeki yani MyList generic classımızdaki dizideki eleman sayısı
            Console.WriteLine(names.Lenght);

            //Listedi yani MyList generic classımızda dizinin içinde tuttuğumuz elemanlar
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
