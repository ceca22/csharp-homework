using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Models
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }

        public Bicycle()
        {

        }

        public Bicycle(int id, string manufacturer, string model, int numberofwheels, int numberoflevels, bool iselectric) : base("bicycle", 2)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            NumberOfWheels = numberofwheels;
            NumberOfSpeedLevels = numberoflevels;
            IsElectric = iselectric;
        }

        public void Ride()
        {
            Console.WriteLine($"The {Model} has {NumberOfSpeedLevels} Speeding Levels.");
        }

        public override void Repair(string brokenPartOfTheVehicle)
        {
            base.Repair(brokenPartOfTheVehicle);
        }

    }
}
