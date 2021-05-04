using AcademyLibrary.Entities.Enums;
using AcademyLibrary.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyServices
{
    public static class Class1
    {

        public static Dictionary<Subjects, Grades> ChecksStudent(List<Student> students, int studentID)
        {

            Dictionary<Subjects, Grades> checkFileStudent = students
                                        .Where(x => x.Id == studentID)
                                        .Select(x => x.AllGrades)
                                        .FirstOrDefault();
        if (checkFileStudent != null)
            return checkFileStudent;
        else return null;
        }

        public static List<Subject> CheckAttendance(List<Subject> subjects, List<Student> students) 
        {
            

            foreach(Subject subject in subjects)
            {
                foreach(Student student in students)
                {
                    if(subject.NameOfSubject == student.CurrentlyListening)
                    {
                        subject.Attendance++;
                    }
                }
            }

            return subjects;
        }

            

        
    }
}
