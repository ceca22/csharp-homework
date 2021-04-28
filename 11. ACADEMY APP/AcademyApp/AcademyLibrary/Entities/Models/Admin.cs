using AcademyLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary.Entities.Models
{
    public class Admin : User
    {
        
        public Admin(int id, string fullName, int age, string username, string pass) : base(id, fullName, age, username, pass)
        {
            Role = AcademyRoles.Admin;
            
        }
    }
}
