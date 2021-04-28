using AcademyLibrary.Entities.Enums;
using AcademyLibrary.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyApp
{
    class Program
    {
        #region check user
        static User CheckUser(List<Trainer> trainers, List<Student> students, List<Admin> admins, string user1, string pass1)
        {
            User currentUser = null;
            
            Trainer trainerLoggedIn = trainers.Where(x => x.Username == user1 && x.Password == pass1).FirstOrDefault();
            Student studentLoggedIn = students.Where(x => x.Username == user1 && x.Password == pass1).FirstOrDefault();
            Admin adminLoggedIn = admins.Where(x => x.Username == user1 && x.Password == pass1).FirstOrDefault();

            if (trainerLoggedIn != null)
            {
                currentUser = trainerLoggedIn;
                return currentUser;
            }
            
            if (studentLoggedIn != null)
            {
                currentUser = studentLoggedIn;
                return currentUser;
            }
            if (adminLoggedIn != null)
            {
                currentUser = adminLoggedIn;
                return currentUser;
            }
            else return currentUser;


        }

        #endregion


        static void Main(string[] args)
        {

            #region trainers
            List<Trainer> trainers = new List<Trainer>()
            {
                new Trainer(3214, "Roberto Nike", 33, "smile_33", "12345678", Subjects.Biochemistry),
                new Trainer(3225, "Sesilija Lovato", 37, "lovely_33", "12345678", Subjects.QualityControl),
                new Trainer(3234, "Stefan Biker", 40, "happy_33", "12345678", Subjects.ConfectioneryTechnology),
                new Trainer(3234, "Marija Shivakovska", 42, "sad_33", "12345678", Subjects.OrganicChemistry),
                new Trainer(3234, "Kosta Mancev", 40, "funny_33", "12345678", Subjects.AnaliticalChemistry),
                new Trainer(3234, "Ilija Kamcev", 31, "meat_33", "12345678", Subjects.TechnologyOfMeatAndMeatProducts),
                new Trainer(3234, "Dejan Petrov", 36, "micro_33", "12345678", Subjects.Microbiology)
               



            };
            #endregion


            #region subjects


            List<Subject> subjectsInTheAcademy = new List<Subject>()
            {
                new Subject(Subjects.Biochemistry, trainers.Where(x => x.Subject == Subjects.Biochemistry).FirstOrDefault()),
                new Subject(Subjects.QualityControl, trainers.Where(x => x.Subject == Subjects.QualityControl).FirstOrDefault()),
                new Subject(Subjects.ConfectioneryTechnology, trainers.Where(x => x.Subject == Subjects.ConfectioneryTechnology).FirstOrDefault()),
                new Subject(Subjects.Microbiology, trainers.Where(x => x.Subject == Subjects.Microbiology).FirstOrDefault()),
                new Subject(Subjects.OrganicChemistry, trainers.Where(x => x.Subject == Subjects.OrganicChemistry).FirstOrDefault()),
                new Subject(Subjects.AnaliticalChemistry, trainers.Where(x => x.Subject == Subjects.AnaliticalChemistry).FirstOrDefault()),
                new Subject(Subjects.TechnologyOfMeatAndMeatProducts, trainers.Where(x => x.Subject == Subjects.TechnologyOfMeatAndMeatProducts).FirstOrDefault())
            };

            //subjectsInTheAcademy.ForEach(x => Console.WriteLine($"{x.CurrentTrainer.FullName} teaches {x.NameOfSubject}"));
            #endregion


            #region students
            List<Student> students = new List<Student>()
            {
                new Student(1111, "Stefan Vasilev", 24, "first_student", "111111", Subjects.Biochemistry, new Dictionary<Subjects, Grades>(){{Subjects.ConfectioneryTechnology, Grades.eight}, { Subjects.Microbiology, Grades.seven}, { Subjects.QualityControl, Grades.failed }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.ten} }),
                new Student(1129, "Ceca Todosieva", 24, "second_student", "111111", Subjects.Biochemistry, new Dictionary<Subjects, Grades>(){{Subjects.ConfectioneryTechnology, Grades.eight}, { Subjects.Microbiology, Grades.seven}, { Subjects.QualityControl, Grades.failed}, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.ten} }),
                new Student(1122, "Tanja Markova", 24, "third_student", "222222", Subjects.QualityControl, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1132, "Marko Stefanov", 24, "forth_student", "222222", Subjects.QualityControl, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1142, "Sandra Majovska", 24, "fifth_student", "222222", Subjects.Biochemistry, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1162, "Maja Peevska", 24, "sixth_student", "222222", Subjects.Biochemistry, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.Biochemistry, Grades.failed}, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1152, "Igor Peshev", 24, "seventh_student", "222222", Subjects.QualityControl, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.failed }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1182, "Dime Ilievski", 24, "eighth_student", "222222", Subjects.TechnologyOfMeatAndMeatProducts, new Dictionary<Subjects, Grades>(){ { Subjects.ConfectioneryTechnology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1192, "Vasko Petrov", 24, "nineth_student", "222222", Subjects.AnaliticalChemistry, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.OrganicChemistry, Grades.ten} }),
                new Student(1193, "Teodora Vitanova", 24, "tenth_student", "222222", Subjects.OrganicChemistry, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1199, "Viktor Lazarov", 24, "eleventh_student", "222222", Subjects.Microbiology, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.ConfectioneryTechnology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.nine} }),
                new Student(1155, "Ivana Tomova", 24, "twelve_student", "222222", Subjects.ConfectioneryTechnology, new Dictionary<Subjects, Grades>(){{Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine}, { Subjects.Microbiology, Grades.ten}, { Subjects.QualityControl, Grades.six }, { Subjects.OrganicChemistry, Grades.ten}, { Subjects.AnaliticalChemistry, Grades.nine} }),
            };
            #endregion


            #region admins
            List<Admin> admins = new List<Admin>()
            {
                new Admin(0001, "Coco Chanel", 47, "admin1", "admin1111"),
                new Admin(0002, "Lola Lolita", 40, "admin2", "admin2222"),
                new Admin(0003, "Goran Vox", 33, "admin3", "admin3333"),
                new Admin(0004, "Mite Milo", 37, "admin4", "admin4444")

            };
            #endregion

            


            //trainers.ForEach(x => Console.WriteLine(x.Role));


            try
            {
                

                
                while (true)
                {

                    #region Login
                    Console.WriteLine("Welcome to Academy App!");
                    Console.Write("Username: ");
                    string user1 = Console.ReadLine();
                    Console.Write("Password: ");
                    string pass1 = Console.ReadLine();
                    User currentUser = CheckUser(trainers, students, admins, user1, pass1);
                    #endregion


                    if (currentUser != null)
                    {
                        Console.Clear();
                        Console.WriteLine($"You have succesfully logged in {currentUser.Role} {currentUser.FullName}");

                        if(currentUser.Role == AcademyRoles.Admin)
                        {
                        
                        Console.WriteLine("What is your next step?");
                        Console.WriteLine("1)Add");
                        Console.WriteLine("2)Remove");
                        int nextMove = int.Parse(Console.ReadLine());

                        #region info 
                        if (nextMove == 1)
                        {
                            for(; ; )
                                {
                                    Console.Clear();

                                    int memberId = 0;

                                    for (; ; )
                                    {
                                        System.Random random = new System.Random();
                                        int randomNum = random.Next(2000, 3500);
                                        //foreach loops za proverka na site nizi da ne se kreira isti memberId
                                        foreach (Trainer trainer in trainers)
                                        {
                                            if (trainer.Id != randomNum)
                                            {
                                                memberId = randomNum;
                                                break;
                                            }
                                        }

                                        foreach (Student student in students)
                                        {
                                            if (student.Id != randomNum)
                                            {
                                                memberId = randomNum;

                                                break;
                                            }
                                        }

                                        foreach (Admin admin in admins)
                                        {
                                            if (admin.Id != randomNum)
                                            {
                                                memberId = randomNum;
                                                break;
                                            }
                                        }

                                        if (memberId == 0) continue;
                                        else
                                        {
                                            Console.WriteLine($"Member Id is: {memberId}");
                                            break;
                                        }
                                    }

                                    Console.Write("Enter Full Name: ");
                                    string fullName = Console.ReadLine();
                                    Console.Write("How old are you? ");
                                    int age = int.Parse(Console.ReadLine());
                                    string userName2 = null;


                                    for (; ; )
                                    {
                                        Console.Write("Create Username: ");
                                        string userName1 = Console.ReadLine();
                                        //foreach loops za proverka na site nizi za da ne se kreirat 2 isti usernames
                                        foreach (Trainer trainer in trainers)
                                        {
                                            if (trainer.Username != userName1)
                                            {
                                                userName2 = userName1;
                                                break;
                                            }
                                        }

                                        foreach (Student student in students)
                                        {
                                            if (student.Username != userName1)
                                            {
                                                userName2 = userName1;
                                                break;
                                            }
                                        }

                                        foreach (Admin admin in admins)
                                        {
                                            if (admin.Username != userName1)
                                            {
                                                userName2 = userName1;
                                                break;
                                            }
                                        }

                                        if (userName2 == null) continue;
                                        else break;
                                    }

                                    Console.Write("Create Password: ");
                                    string pass = Console.ReadLine();

                                    #endregion

                                    Console.WriteLine("----------------------");

                                    Console.WriteLine("Choose:");
                                    Console.WriteLine("1)Admin");
                                    Console.WriteLine("2)Trainer");
                                    Console.WriteLine("3)Student");

                                    int moveTwo = int.Parse(Console.ReadLine());


                                    if (moveTwo == 1)
                                    {



                                    }
                                    else if (moveTwo == 2)
                                    {

                                        #region trainer properties
                                        Subjects subjectToTeach = 0;
                                        int chooseSubject;

                                        for (; ; )
                                        {
                                            Console.WriteLine("Choose a subject to teach students");
                                            Console.WriteLine($"1){Subjects.AnaliticalChemistry}");
                                            Console.WriteLine($"2){Subjects.Biochemistry}");
                                            Console.WriteLine($"3){Subjects.ConfectioneryTechnology}");
                                            Console.WriteLine($"4){Subjects.Microbiology}");
                                            Console.WriteLine($"5){Subjects.OrganicChemistry}");
                                            Console.WriteLine($"6){Subjects.QualityControl}");
                                            Console.WriteLine($"7){Subjects.TechnologyOfMeatAndMeatProducts}");
                                            chooseSubject = int.Parse(Console.ReadLine());

                                            switch (chooseSubject)
                                            {
                                                case 1:
                                                    subjectToTeach = Subjects.AnaliticalChemistry;
                                                    break;
                                                case 2:
                                                    subjectToTeach = Subjects.Biochemistry;
                                                    break;
                                                case 3:
                                                    subjectToTeach = Subjects.ConfectioneryTechnology;
                                                    break;
                                                case 4:
                                                    subjectToTeach = Subjects.Microbiology;
                                                    break;
                                                case 5:
                                                    subjectToTeach = Subjects.OrganicChemistry;
                                                    break;
                                                case 6:
                                                    subjectToTeach = Subjects.QualityControl;
                                                    break;
                                                case 7:
                                                    subjectToTeach = Subjects.TechnologyOfMeatAndMeatProducts;
                                                    break;
                                                default:
                                                    Console.WriteLine("No such subject");
                                                    break;
                                            }

                                            if (subjectToTeach == 0) continue;
                                            else break;




                                        }

                                        Trainer newTrainer = new Trainer(memberId, fullName, age, userName2, pass, subjectToTeach);
                                        Console.WriteLine($"You have successfully registered a new trainer {newTrainer.FullName} who teaches {newTrainer.Subject}.");

                                        #endregion

                                    }
                                    else if (moveTwo == 3)
                                    {
                                        Subjects currentlyListening = 0;
                                        int chooseSubject;
                                        #region student properties
                                        for (; ; )
                                        {
                                            Console.WriteLine($"Choose a subject that {fullName} listens to:");
                                            Console.WriteLine($"1){Subjects.AnaliticalChemistry}");
                                            Console.WriteLine($"2){Subjects.Biochemistry}");
                                            Console.WriteLine($"3){Subjects.ConfectioneryTechnology}");
                                            Console.WriteLine($"4){Subjects.Microbiology}");
                                            Console.WriteLine($"5){Subjects.OrganicChemistry}");
                                            Console.WriteLine($"6){Subjects.QualityControl}");
                                            Console.WriteLine($"7){Subjects.TechnologyOfMeatAndMeatProducts}");
                                            chooseSubject = int.Parse(Console.ReadLine());

                                            switch (chooseSubject)
                                            {
                                                case 1:
                                                    currentlyListening = Subjects.AnaliticalChemistry;
                                                    break;
                                                case 2:
                                                    currentlyListening = Subjects.Biochemistry;
                                                    break;
                                                case 3:
                                                    currentlyListening = Subjects.ConfectioneryTechnology;
                                                    break;
                                                case 4:
                                                    currentlyListening = Subjects.Microbiology;
                                                    break;
                                                case 5:
                                                    currentlyListening = Subjects.OrganicChemistry;
                                                    break;
                                                case 6:
                                                    currentlyListening = Subjects.QualityControl;
                                                    break;
                                                case 7:
                                                    currentlyListening = Subjects.TechnologyOfMeatAndMeatProducts;
                                                    break;
                                                default:
                                                    Console.WriteLine("No such subject");
                                                    break;
                                            }

                                            if (currentlyListening == 0) continue;
                                            else break;




                                        }
                                        Dictionary<Subjects, Grades> gradesForSubjects = new Dictionary<Subjects, Grades>();
                                        for (; ; )
                                        {

                                            int counter = 1;
                                            foreach (Subject subject in subjectsInTheAcademy)
                                            {
                                                Console.WriteLine($"{counter++}) {subject.NameOfSubject}");
                                            }


                                            for (; ; )
                                            {
                                                Console.WriteLine("Choose a subject");
                                                int chooseSubject2 = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter a grade from 6 to 10 or 5 for failed");
                                                int grade = int.Parse(Console.ReadLine());


                                                switch (chooseSubject2)
                                                {
                                                    case 1:
                                                        if (currentlyListening != Subjects.AnaliticalChemistry)
                                                        {
                                                            #region choose a grade


                                                            switch (grade)
                                                            {
                                                                case 5:
                                                                    gradesForSubjects.Add(Subjects.AnaliticalChemistry, Grades.failed);
                                                                    break;
                                                                case 6:
                                                                    gradesForSubjects.Add(Subjects.AnaliticalChemistry, Grades.six);

                                                                    break;
                                                                case 7:

                                                                    gradesForSubjects.Add(Subjects.AnaliticalChemistry, Grades.seven);

                                                                    break;
                                                                case 8:
                                                                    gradesForSubjects.Add(Subjects.AnaliticalChemistry, Grades.eight);

                                                                    break;
                                                                case 9:
                                                                    gradesForSubjects.Add(Subjects.AnaliticalChemistry, Grades.nine);

                                                                    break;
                                                                case 10:
                                                                    gradesForSubjects.Add(Subjects.AnaliticalChemistry, Grades.ten);

                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Wrong Input");
                                                                    break;
                                                            }

                                                            #endregion
                                                        }
                                                        break;
                                                    case 2:
                                                        if (currentlyListening != Subjects.Biochemistry)
                                                        {
                                                            #region choose a grade


                                                            switch (grade)
                                                            {
                                                                case 5:
                                                                    gradesForSubjects.Add(Subjects.Biochemistry, Grades.failed);

                                                                    break;
                                                                case 6:
                                                                    gradesForSubjects.Add(Subjects.Biochemistry, Grades.six);

                                                                    break;
                                                                case 7:

                                                                    gradesForSubjects.Add(Subjects.Biochemistry, Grades.seven);

                                                                    break;
                                                                case 8:
                                                                    gradesForSubjects.Add(Subjects.Biochemistry, Grades.eight);

                                                                    break;
                                                                case 9:
                                                                    gradesForSubjects.Add(Subjects.Biochemistry, Grades.nine);

                                                                    break;
                                                                case 10:
                                                                    gradesForSubjects.Add(Subjects.Biochemistry, Grades.ten);

                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Wrong Input");
                                                                    break;
                                                            }

                                                            #endregion
                                                        }
                                                        break;
                                                    case 3:
                                                        if (currentlyListening != Subjects.ConfectioneryTechnology)
                                                        {
                                                            #region choose a grade



                                                            switch (grade)
                                                            {
                                                                case 5:
                                                                    gradesForSubjects.Add(Subjects.ConfectioneryTechnology, Grades.failed);

                                                                    break;
                                                                case 6:
                                                                    gradesForSubjects.Add(Subjects.ConfectioneryTechnology, Grades.six);

                                                                    break;
                                                                case 7:

                                                                    gradesForSubjects.Add(Subjects.ConfectioneryTechnology, Grades.seven);

                                                                    break;
                                                                case 8:
                                                                    gradesForSubjects.Add(Subjects.ConfectioneryTechnology, Grades.eight);

                                                                    break;
                                                                case 9:
                                                                    gradesForSubjects.Add(Subjects.ConfectioneryTechnology, Grades.nine);

                                                                    break;
                                                                case 10:
                                                                    gradesForSubjects.Add(Subjects.ConfectioneryTechnology, Grades.ten);

                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Wrong Input");
                                                                    break;
                                                            }

                                                            #endregion
                                                        }

                                                        break;
                                                    case 4:
                                                        if (currentlyListening != Subjects.Microbiology)
                                                        {
                                                            #region choose a grade



                                                            switch (grade)
                                                            {
                                                                case 5:
                                                                    gradesForSubjects.Add(Subjects.Microbiology, Grades.failed);

                                                                    break;
                                                                case 6:
                                                                    gradesForSubjects.Add(Subjects.Microbiology, Grades.six);

                                                                    break;
                                                                case 7:

                                                                    gradesForSubjects.Add(Subjects.Microbiology, Grades.seven);

                                                                    break;
                                                                case 8:
                                                                    gradesForSubjects.Add(Subjects.Microbiology, Grades.eight);

                                                                    break;
                                                                case 9:
                                                                    gradesForSubjects.Add(Subjects.Microbiology, Grades.nine);

                                                                    break;
                                                                case 10:
                                                                    gradesForSubjects.Add(Subjects.Microbiology, Grades.ten);

                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Wrong Input");
                                                                    break;
                                                            }

                                                            #endregion

                                                        }

                                                        break;
                                                    case 5:
                                                        if (currentlyListening != Subjects.OrganicChemistry)
                                                        {
                                                            #region choose a grade



                                                            switch (grade)
                                                            {
                                                                case 5:
                                                                    gradesForSubjects.Add(Subjects.OrganicChemistry, Grades.failed);

                                                                    break;
                                                                case 6:
                                                                    gradesForSubjects.Add(Subjects.OrganicChemistry, Grades.six);

                                                                    break;
                                                                case 7:

                                                                    gradesForSubjects.Add(Subjects.OrganicChemistry, Grades.seven);

                                                                    break;
                                                                case 8:
                                                                    gradesForSubjects.Add(Subjects.OrganicChemistry, Grades.eight);

                                                                    break;
                                                                case 9:
                                                                    gradesForSubjects.Add(Subjects.OrganicChemistry, Grades.nine);

                                                                    break;
                                                                case 10:
                                                                    gradesForSubjects.Add(Subjects.OrganicChemistry, Grades.ten);

                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Wrong Input");
                                                                    break;
                                                            }

                                                            #endregion
                                                        }
                                                        break;
                                                    case 6:
                                                        if (currentlyListening != Subjects.QualityControl)
                                                        {
                                                            #region choose a grade



                                                            switch (grade)
                                                            {
                                                                case 5:
                                                                    gradesForSubjects.Add(Subjects.QualityControl, Grades.failed);

                                                                    break;
                                                                case 6:
                                                                    gradesForSubjects.Add(Subjects.QualityControl, Grades.six);

                                                                    break;
                                                                case 7:

                                                                    gradesForSubjects.Add(Subjects.QualityControl, Grades.seven);

                                                                    break;
                                                                case 8:
                                                                    gradesForSubjects.Add(Subjects.QualityControl, Grades.eight);

                                                                    break;
                                                                case 9:
                                                                    gradesForSubjects.Add(Subjects.QualityControl, Grades.nine);

                                                                    break;
                                                                case 10:
                                                                    gradesForSubjects.Add(Subjects.QualityControl, Grades.ten);

                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Wrong Input");
                                                                    break;
                                                            }

                                                            #endregion
                                                        }
                                                        break;
                                                    case 7:
                                                        if (currentlyListening != Subjects.TechnologyOfMeatAndMeatProducts)
                                                        {
                                                            #region choose a grade



                                                            switch (grade)
                                                            {
                                                                case 5:
                                                                    gradesForSubjects.Add(Subjects.TechnologyOfMeatAndMeatProducts, Grades.failed);

                                                                    break;
                                                                case 6:
                                                                    gradesForSubjects.Add(Subjects.TechnologyOfMeatAndMeatProducts, Grades.six);

                                                                    break;
                                                                case 7:

                                                                    gradesForSubjects.Add(Subjects.TechnologyOfMeatAndMeatProducts, Grades.seven);

                                                                    break;
                                                                case 8:
                                                                    gradesForSubjects.Add(Subjects.TechnologyOfMeatAndMeatProducts, Grades.eight);

                                                                    break;
                                                                case 9:
                                                                    gradesForSubjects.Add(Subjects.TechnologyOfMeatAndMeatProducts, Grades.nine);

                                                                    break;
                                                                case 10:
                                                                    gradesForSubjects.Add(Subjects.TechnologyOfMeatAndMeatProducts, Grades.ten);

                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Wrong Input");
                                                                    break;
                                                            }

                                                            #endregion
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("No such subject");
                                                        break;
                                                }
                                                Console.WriteLine("Would you like to add more? enter yes or no");
                                                string answer = Console.ReadLine().ToLower();
                                                if (answer == "yes") continue;
                                                else break;
                                            }
                                            break;
                                        }

                                        #endregion


                                        Student newStudent = new Student(memberId, fullName, age, userName2, pass, currentlyListening, gradesForSubjects);

                                        Console.WriteLine($"You have succesfully added a new student {newStudent.FullName}  that currently listents to {newStudent.CurrentlyListening}");
                                        Console.WriteLine("Current Grades");

                                        foreach (var item in gradesForSubjects)
                                        {
                                            Console.WriteLine($"Subject: {item.Key}| Grade: {item.Value} ");

                                        }
                                        Console.WriteLine("------------------------------");
                                        break;
                                    }
                                }
                                continue;
                                
                        }
                        else if (nextMove == 2){

                            Console.Clear();
                            Console.WriteLine("Choose:");
                            Console.WriteLine("1)Admin");
                            Console.WriteLine("2)Trainer");
                            Console.WriteLine("3)Student");
                            int moveTwo = int.Parse(Console.ReadLine());
                        }  
                        else
                        {
                            Console.WriteLine("No such option!");
                            continue;
                        }

                        } else if(currentUser.Role == AcademyRoles.Trainer)
                        {

                        }else if(currentUser.Role == AcademyRoles.Student)
                        {

                        }
                        

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No such User");
                        
                        continue;
                    }
                      

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}





