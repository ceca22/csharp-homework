using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models
{
    //    Task 2
    //Create the classes Employee and User which will inherit from the Member class 
    //        and will have its own properties and methods.
    //        Make sure they have constructors with all the properties from the parent constructor plus their own, 
    //        if they are not private (use base)

    //Employee
    //Salary => not accessible property from outside, which should have default value when instantiating an 
    //        object from Employee class of 300 eur
    //HoursPerMonth

    //Bonus
    //SetBonus => method that will dynamically set Bonus to the Employee by checking:
    //    if the employee has HoursPerMonth > 160 hours it should be 30% (0.3) 
    //        If the employee has HoursPerMonth< 160 then it should be set to null (check nullable integer)
    //SetSalary => method that should set the value to the Salary property by 
    //        doing the multiplication of HoursPerMonth * Bonus


    public class Employee : Member
    {
        protected double Salary { get; set; }
        public int HoursPerMonth { get; set; }

        public double Bonus { get; set; }
      

        public Employee(string salary)
        {
            Salary = 300;
            //if they are not private (use base) -vo tekstot na zadacata go imashe spomnato ova ama
            //osven so base na casot reshavavme i na vakov nacin so zadavanje vrednost vo konstruktorot
            //plus vo ovaa situacija ne mozam so base zatoa shto Salary e property na employee
        }
        
        
        public Employee(string firstName, string lastName, int age, string userName, string pasword, int phoneNumber, DateTime dateOfRegistration, MovieStoreRole role, int hoursPermonth)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = pasword;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            Role = role;
            Salary = 300;
            HoursPerMonth = hoursPermonth;
            
        }


        //300euros/160 hours= 1.875 per hour
        //if more than 160=> let's say 180 then 180-160 = 20 hours overtime * 1.875(per hour) = 37.5 euros
        //znam deka overtime e razlicno od bonus ama za sekoj slucaj da prasham po koja matematika da odam
        //po ovaa shto ja zakomentirav ili taa shto mi e napishana na 79ta linija
        public double SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                return Bonus = 0.3;
            } else 
            {
                return Bonus = 0;
                //se ocekuva double varijabla zatoa ne mozam da iskoristam null.....
                //shto beshe celta so toj uslov za null?
            }
        }

        public double SetSalary()
        {
            return Salary +=  Bonus * HoursPerMonth;
        }
    }
}
