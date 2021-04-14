using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary.Models
{
    public class ElectricalCar : Car
    {

        public string BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }

        //public ElectricalCar()
        //{

        //}

        public ElectricalCar() : base(EngineTypes.Electrical)
        {

        }

       


        public void Recharge()
        {
            if (BatteryPercentage > 50)
            {
                Console.WriteLine($"The battery will last for another 20 hours of driving.");
                return;
            } else if (BatteryPercentage < 40)
            {
                Console.WriteLine($"The battery will last for another 10 hours of driving.");
                return;

            } else if (BatteryPercentage < 20)
            {
                Console.WriteLine($"You should charge the battery in the next 2 hours!");
                return;
            }
        }

        public override void Drive(int maxspeed)
        {
            base.Drive(maxspeed);
        }

    }
}
