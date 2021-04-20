using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Models
{
    public class WheeledVehicle : Vehicle
    {

        public int NumberOfWheels { get; set; }
        public string Type { get; set; }
           
        public WheeledVehicle() 
        {

        }

        

        public WheeledVehicle(string type, int numberofwheels)
        {
            Type = type;
            NumberOfWheels = numberofwheels;
        }

        public void  Repair()
        {
            Console.WriteLine($"The {Type} doesn't have any deffects!");
        }

        public virtual void Repair(string brokenPartOfTheVehicle)
        {
            Console.WriteLine($"The {brokenPartOfTheVehicle} has a deffect and it needs to be repaired!");
        }
    }
}
