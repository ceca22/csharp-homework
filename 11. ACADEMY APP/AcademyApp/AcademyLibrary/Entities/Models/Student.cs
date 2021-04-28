using AcademyLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary.Entities.Models
{
    public class Student : User
    {
        public Subjects CurrentlyListening { get; set; }
        public Dictionary<Subjects, Grades> AllGrades { get; set; } = new Dictionary<Subjects, Grades>();

        public Student(int id, string fullName, int age, string username, string pass, Subjects currentlyListening, Dictionary<Subjects,Grades> allGrades) : base(id, fullName, age, username, pass)
        {
            CurrentlyListening = currentlyListening;
            Role = AcademyRoles.Student;
            AllGrades = allGrades;
        }

    }
}
