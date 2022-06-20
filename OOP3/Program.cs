using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacelerde o interface'i implemnte eden classın refenrans numarasını tutabilir.
            //Farklı kredilerin hesaplama işlemi
            ICreditManager personelCreditManager = new PersonelCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService dataLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();
            creditApplicationManager.MakeApplication(new BusinessCreditManager(), new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });



            List<ICreditManager> credits = new List<ICreditManager>() { personelCreditManager, transportCreditManager };
            //creditApplicationManager.CreditPreInfo(credits);

            Console.ReadLine();
        }
    }
}
