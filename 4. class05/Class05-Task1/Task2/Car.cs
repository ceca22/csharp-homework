using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    //Make a class Car. Add properties: Model, Speed and Driver
    //Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill
    //multiplied by the speed of the car and return it as a result.

    public class Car
    {

        public Car()
        {

        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }


        public int CalculateSpeed(Driver driver)
        {
            int speedCalculation = driver.Skill * Speed;
            return speedCalculation;
        }


    }
}
