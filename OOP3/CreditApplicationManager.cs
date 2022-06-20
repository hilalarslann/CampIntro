using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Kredi Başvuru Yöneticisi
    class CreditApplicationManager
    {
        //Başvuru Yap
        /*Interface sayesinde kredi başvurusunda hesaplama yaptırırken 
        parametre olarak artık istediğim kredi türünü verebilirim */

        //Method injeciton
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.CreditCalculation();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.CreditCalculation(); 
            }
        }
    }
}
