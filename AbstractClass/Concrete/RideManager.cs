using AbstractClass.Abstract;
using AbstractClass.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Concrete
{
    class RideManager : BaseVehicleManager, IRideable, IPurchaseService
    {
        public void PriceCalculation()
        {
            Console.WriteLine("Araç fiyatı hesaplandı");
        }

        public void Ride(Vehicle vehicle)
        {
            Console.WriteLine("Sürüldü" + vehicle.Plate);
        }
    }
}
