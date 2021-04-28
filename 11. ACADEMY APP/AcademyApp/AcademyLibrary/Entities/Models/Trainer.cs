using AcademyLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AcademyLibrary.Entities.Models
{
    public class Trainer : User
    {
        public Subjects Subject { get; set; } 

        public Trainer(int id,string fullName, int age, string username, string pass, Subjects subject):base(id, fullName, age, username, pass)
        {
            Role = AcademyRoles.Trainer;
            Subject = subject;
        }
    }
}
