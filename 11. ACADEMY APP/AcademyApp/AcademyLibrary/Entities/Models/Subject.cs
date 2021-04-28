using AcademyLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary.Entities.Models
{
    public class Subject
    {
        public Subjects NameOfSubject { get; set; }
        public Trainer CurrentTrainer { get; set; }

        public Subject()
        {

        }
        public Subject(Subjects nameOfSubjects, Trainer currentTrainer)
        {
            NameOfSubject = nameOfSubjects;
            CurrentTrainer = currentTrainer;
        }

    }
}
