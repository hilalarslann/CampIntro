using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelCreditManager : ICreditManager
    {
        public void CreditCalculation()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void CreditScreenOutput()
        {
            throw new NotImplementedException();
        }
    }
}
