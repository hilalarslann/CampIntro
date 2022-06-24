using AbstractClass.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Concrete
{
    class VehiclePurchaseManager
    {
        public void Buy(IPurchaseService purchaseService)
        {
            purchaseService.PriceCalculation();
        }
    }
}
