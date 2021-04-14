using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Models
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }

        public Bicycle() : base("bicycle")
        {

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
