using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void CreditCalculation()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }

        public void CreditScreenOutput()
        {
            throw new NotImplementedException();
        }
    }
}
