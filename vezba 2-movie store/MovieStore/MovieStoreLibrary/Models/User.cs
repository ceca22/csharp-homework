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
        public string[] Movies { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName, int age, string userName, string pasword, int phoneNumber, DateTime dateOfRegistration, MovieStoreRole role, int memberId, TypeOfSubscription subscription, string[] movies)
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
        }

        public string showMovies()
        {
            string user = $"{FirstName} {LastName} usually rents ";
            for (int i=0; i < Movies.Length; i++)
            {
                if (Movies.Length > 1)
                    user += $"{Movies[i]}, ";
                else if (Movies.Length == 1)
                    user += Movies[i];
                else
                    user = "Hasn't rented yet";
            }
            return user;
        }

    }
}
