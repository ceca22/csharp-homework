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


        public ElectricalCar() 
        {
            
        }
        public ElectricalCar(int id, string model, string manufacturer, int numberofwheels, int doors, int speed, string batterycapacity, int batterypercentage) : base(EngineTypes.Electrical)
        {
            Id = id;
            Model = model;
            Manufacturer = manufacturer;
            NumberOfWheels = numberofwheels;

            FuelConsumption = 0; //ova property e setirano na 0 zatoa shto ne koristi gorivo
            Type = "Electrical Car";

            NumberOfDoors = doors;
            MaxSpeed = speed;
            BatteryCapacity = batterycapacity;
            BatteryPercentage = batterypercentage;
        }

       
        //ne razbrav shto tocno treba da napravam za ovoj uslov-Set maxSpeed when on battery
        

        public void Recharge()
        {
            if (BatteryPercentage < 100)
            {
                BatteryPercentage = 100;
                Console.WriteLine("Your battery has just been recharged to 100%");
            } else
            {
                Console.WriteLine("Battery is 100%");
            }
        }

        public override void Drive(int maxspeed)
        {
            base.Drive(maxspeed);
            BatteryPercentage -= 23; //koga se povikuva ovaa funkcija se namaluva baterijata
        }

    }
}
