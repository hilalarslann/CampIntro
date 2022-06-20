using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BusinessCreditManager : ICreditManager
    {
        public void CreditCalculation()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void CreditScreenOutput()
        {
            throw new NotImplementedException();
        }
    }
}
