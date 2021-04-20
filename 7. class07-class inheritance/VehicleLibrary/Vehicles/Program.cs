using System;
using VehicleLibrary.Models;
using VehicleLibrary.Enums;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------El.Car-----------");
            ElectricalCar car01 = new ElectricalCar(32415, "Model S.", "Tesla", 4, 5, 249, "100 kWh", 85);
            car01.PrintInfo();
            
            Console.WriteLine($"Engine Type: {car01.EngineType}");
            Console.WriteLine($"Fuel Consumption: {car01.FuelConsumption}");
            Console.WriteLine($"Battery: {car01.BatteryPercentage} % ");
            car01.Drive(249);

            Console.WriteLine($"Battery: {car01.BatteryPercentage} % ");
            car01.Recharge();
            Console.WriteLine($"Battery: {car01.BatteryPercentage} % ");


            Console.WriteLine("----------------Car-----------");

            Car car03 = new Car(4321, "G20", "BMW", 4, 5.9, 4, 250, EngineTypes.Thermal);
            
            car03.PrintInfo();
            Console.WriteLine($"Fuel Consumption: {car03.FuelConsumption}");
            car03.Drive(250);
            Console.WriteLine($"Fuel Consumption: {car03.FuelConsumption}");

            car03.Repair("brakes");

            
            Console.WriteLine("----------------Bicycle-----------");

            Bicycle bike01 = new Bicycle(23456, "Liv", "Liv Lust Advanced 1", 3, 10, false);
            Console.WriteLine($"Model: {bike01.Model}");
            bike01.PrintInfo();
            bike01.Ride();
            bike01.Repair("seat");

            

        }
    }
}
