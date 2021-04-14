using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models
{
    public class Member
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public int PhoneNumber { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public MovieStoreRole Role { get; set; }

        

        public Member()
        {

        }

        
        public Member(string firstName, string lastName, int age, string userName, string pasword, int phoneNumber, DateTime dateOfRegistration, MovieStoreRole role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = pasword;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            Role = role;
                

        }

        public void Displayinfo()
        {
            Console.WriteLine($"{FirstName} {LastName} | Registered on: {DateOfRegistration}");
        }
    }
}
