using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Models
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int id, string manufacturer, string model)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"{Id} : {Model} | Manufacturer: {Manufacturer}");
        }
    }
}
