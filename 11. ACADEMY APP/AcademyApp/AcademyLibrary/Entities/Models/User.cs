using AcademyLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary.Entities.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public AcademyRoles Role { get; set; }

        public User()
        {
            
        }

        public User(int id, string fullName, int age, string username, string pass)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Username = username;
            Password = pass;
            
            
        }
    }
}
