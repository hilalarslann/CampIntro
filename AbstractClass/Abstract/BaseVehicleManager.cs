using AbstractClass.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Abstract
{
    public abstract class BaseVehicleManager : IVehicleService
    {
        public void Go(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle is going.." + vehicle.Plate);
        }

        public void Stop(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle has stopped.." + vehicle.Plate);
        }
    }
}
