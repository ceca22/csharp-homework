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

        //public Car ()
        //{

        //}

        public Car() : base("car")
        {

        }

        public Car(EngineTypes enginetype)
        {
            EngineType = enginetype;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Type}:{Model} with {EngineType} is driving.");
        }

        public virtual void Drive(int maxspeed)
        {
            Console.WriteLine($"The {Type}:{Model} with {EngineType} is driving max speed of {maxspeed} km/h.");
        }

        public override void Repair(string brokenPartOfTheVehicle)
        {
            base.Repair(brokenPartOfTheVehicle);
        }



    }


    
}
