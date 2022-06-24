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
            var baseVehicle = new RideManager();
            baseVehicle.Go(new Vehicle());
            baseVehicle.Ride(new Vehicle());

            var baseVehicle2 = new FlyManager();
            baseVehicle2.Soar();

            Console.ReadLine();
        }
    }
}
