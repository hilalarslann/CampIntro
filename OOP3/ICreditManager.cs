using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Okunurluğu arttırmak için interface isimlerinin başına I harfi ekleriz
    /*İmzanın(Tüm farklı krediler için kredi hesapla metot kısmı) aynı olduğu 
      ama içerisinin farklı olduğu durumlarda base oluşturduğumuz classı
      class olarak değil interface olarak oluştururuz. */

    interface ICreditManager
    {
        void CreditCalculation();

        void CreditScreenOutput();
    }
}
