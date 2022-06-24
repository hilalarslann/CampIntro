using AbstractClass.Abstract;
using AbstractClass.Concrete;
using AbstractClass.Entites;
using System;
using System.Collections.Generic;

namespace AbstractInterfaceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseVehicleManager baseVehicle = new RideManager();
            baseVehicle.Go(new Vehicle());

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle() { Id = 1, Plate = "bisiklet" });
            vehicles.Add(new Vehicle() { Id = 2, Plate = "uçak" });

            foreach (var vehicle in vehicles)
            {
                if (vehicle is IRideable)
                {
                    (vehicle as IRideable).Ride(vehicle);
                }
            }

            Console.ReadLine();
        }
    }
}
