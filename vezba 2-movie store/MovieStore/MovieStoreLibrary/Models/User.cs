using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models
{
    //    User
    //MemberNumber(something like an ID)
    //TypeOfSubscription(Monthly, Annually) => enum or class (it’s up to you)
    //Movies => array of Movie type

    public class User : Member
    {
        public int MemberId { get; set; }
        public TypeOfSubscription Subscription { get; set; }
        public Movie[] Movies { get; set; }

        public bool Removed { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName, int age, string userName, string pasword, int phoneNumber, DateTime dateOfRegistration, MovieStoreRole role, int memberId, TypeOfSubscription subscription, Movie[] movies)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = pasword;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            Role = role;
            MemberId = memberId;
            Subscription = subscription;
            Movies = movies;
            Removed = false;
        }

        public string showMovies()
        {
            string user = $"{FirstName} {LastName} has rented ";
            for (int i = 0; i < Movies.Length; i++)
            {
                if (Movies.Length > 1)
                    user += $"{Movies[i].Title}, ";
                else if (Movies.Length == 1)
                    user += Movies[i].Title;
                else
                    user = "Hasn't rented yet";
            }
            return user;
        }

        public void Details()
        {
            Console.WriteLine($"{MemberId} : {FirstName} {LastName} | {showMovies()} ");
        }

    }
}
