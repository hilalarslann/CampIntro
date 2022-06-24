using AbstractClass.Abstract;
using AbstractClass.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Concrete
{
    public class FlyManager : BaseVehicleManager, IFlyable, IPurchaseService
    {
        public void PriceCalculation()
        {
            throw new NotImplementedException();
        }

        public void Soar(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
