using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void CreditCalculation()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }

        public void CreditScreenOutput()
        {
            throw new NotImplementedException();
        }
    }
}
