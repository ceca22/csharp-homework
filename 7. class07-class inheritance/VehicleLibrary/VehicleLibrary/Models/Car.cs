using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary.Models
{
    public class Car : WheeledVehicle
    {

        public EngineTypes EngineType { get; set; }
        
        public double FuelConsumption { get; set; }

        public int NumberOfDoors { get; set; }

        public int MaxSpeed { get; set; }


        public Car()
        {

        }


        public Car(int id, string model,  string manufacturer, int numberofwheels, double fuelconsumption, int doors, int speed, EngineTypes enginetype) : base("Car", 4)
        {
            Id = id;
            Model = model;
            
            Manufacturer = manufacturer;
            NumberOfWheels = numberofwheels;

            FuelConsumption = fuelconsumption;
            NumberOfDoors = doors;
            MaxSpeed = speed;
            EngineType = enginetype;
        }

        public Car(EngineTypes enginetype)
        {
            EngineType = enginetype;
        }
        

        public void Drive()
        {
            Console.WriteLine($"The {Model} with  {EngineType} egine type is driving.");

        }

        public virtual void Drive(int maxspeed)
        {
            
            Console.WriteLine($"The {Type} : {Model} with {EngineType} egine type is driving max speed of {maxspeed} km/h.");
            FuelConsumption -= 2; 
        }
        

        public override void Repair(string brokenPartOfTheVehicle)
        {
            base.Repair(brokenPartOfTheVehicle);
        }



    }


    
}
