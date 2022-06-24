using AbstractClass.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Abstract
{
    public interface IVehicleService
    {
        void Go(Vehicle vehicle);
        void Stop(Vehicle vehicle);
    }
}
