using AcademyLibrary.Entities.Enums;
using AcademyLibrary.Entities.Models;
using AcademyServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppAcademy
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
                new Trainer(3235, "Marija Shivakovska", 42, "sad_33", "12345678", Subjects.OrganicChemistry),
                new Trainer(3236, "Kosta Mancev", 40, "funny_33", "12345678", Subjects.AnaliticalChemistry),
                new Trainer(3237, "Ilija Kamcev", 31, "meat_33", "12345678", Subjects.TechnologyOfMeatAndMeatProducts),
                new Trainer(3238, "Dejan Petrov", 36, "micro_33", "12345678", Subjects.Microbiology)




            };
            #endregion


            #region subjects


            List<Subject> subjectsInTheAcademy = new List<Subject>()
            {
                 new Subject(Subjects.AnaliticalChemistry, trainers.Where(x => x.Subject == Subjects.AnaliticalChemistry).FirstOrDefault()),
                new Subject(Subjects.Biochemistry, trainers.Where(x => x.Subject == Subjects.Biochemistry).FirstOrDefault()),
                new Subject(Subjects.ConfectioneryTechnology, trainers.Where(x => x.Subject == Subjects.ConfectioneryTechnology).FirstOrDefault()),
                
                
                new Subject(Subjects.Microbiology, trainers.Where(x => x.Subject == Subjects.Microbiology).FirstOrDefault()),
                new Subject(Subjects.OrganicChemistry, trainers.Where(x => x.Subject == Subjects.OrganicChemistry).FirstOrDefault()),
               new Subject(Subjects.QualityControl, trainers.Where(x => x.Subject == Subjects.QualityControl).FirstOrDefault()),
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






            try
            {

                

                while (true)
                {
                    User currentUser = null;
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to Academy App!");
                        Console.Write("Username: ");
                        string user1 = Console.ReadLine();
                        Console.Write("Password: ");
                        string pass1 = Console.ReadLine();
                        currentUser = CheckUser(trainers, students, admins, user1, pass1);

                        if (currentUser != null)
                        {
                            Console.Clear();
                            Console.WriteLine($"You have succesfully logged in as {currentUser.Role} -{currentUser.FullName}");
                            break;

                        } else
                        {
                            Console.WriteLine("No such user");
                            
                            continue;
                        }


                    }



                    while (true)
                    {

                        if (currentUser.Role == AcademyRoles.Admin)
                        {
                            #region admin login
                            Console.WriteLine("----------------------");
                            Console.WriteLine("What is your next step?");
                            Console.WriteLine("1)Add");
                            Console.WriteLine("2)Remove");
                            Console.WriteLine("3)Log Out");
                            Console.WriteLine("----------------------");

                            int nextMove = int.Parse(Console.ReadLine());

                            if (nextMove == 1)
                            {
                                Console.Clear();

                                int memberId = 0;

                                #region check memberId 

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
                                #endregion

                                Console.Write("Enter Full Name: ");
                                string fullName = Console.ReadLine();
                                Console.Write("How old are you? ");
                                int age = int.Parse(Console.ReadLine());
                                string userName2 = null;

                                #region check username
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




                                #endregion

                                Console.Write("Create Password: ");
                                string pass = Console.ReadLine();

                                Console.WriteLine("----------------------");

                                Console.WriteLine("Choose:");
                                Console.WriteLine("1)Admin");
                                Console.WriteLine("2)Trainer");
                                Console.WriteLine("3)Student");

                                int moveTwo = int.Parse(Console.ReadLine());

                                switch (moveTwo)
                                {
                                    case 1:
                                        Console.Clear();
                                        Admin newAdmin = new Admin(memberId, fullName, age, userName2, pass);
                                        admins.Add(newAdmin);
                                        Console.WriteLine($"You have successfully registered a new ADMIN {newAdmin.FullName}!");


                                        break;

                                    case 2:
                                        #region trainer properties
                                        Subjects subjectToTeach = 0;
                                        int chooseSubject;
                                        Console.Clear();

                                        for (; ; )
                                        {
                                            Console.WriteLine("Choose a subject to teach students");

                                            int counter4 = 1;
                                            subjectsInTheAcademy.ForEach(x => Console.WriteLine($"{counter4++}) {x.NameOfSubject} "));

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
                                        Console.Clear();
                                        Console.WriteLine($"You have successfully registered a new trainer {newTrainer.FullName} who teaches {newTrainer.Subject}.");
                                        trainers.Add(newTrainer);
                                        #endregion
                                        break;

                                    case 3:

                                        #region currently listening
                                        Subjects currentlyListening = 0;
                                        int chooseSubject2;

                                        for (; ; )
                                        {
                                            Console.WriteLine($"Choose a subject that {fullName} listens to:");
                                            int counter2 = 1;
                                            subjectsInTheAcademy.ForEach(x => Console.WriteLine($"{counter2++}) {x.NameOfSubject} "));
                                            chooseSubject2 = int.Parse(Console.ReadLine());

                                            switch (chooseSubject2)
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
                                        #endregion


                                        #region add subjects and grades
                                        Dictionary<Subjects, Grades> gradesForSubjects = new Dictionary<Subjects, Grades>();


                                        int counter = 1;
                                        Console.WriteLine($"Choose a subject that {fullName} has passed:");
                                        foreach (Subject subject in subjectsInTheAcademy)
                                        {
                                            Console.WriteLine($"{counter++}) {subject.NameOfSubject}");
                                        }


                                        //ova property mi e malce iskomplicirano zatoa shto all grades e dictionary shto poseduva 2 parametri od tip enum subjects i grades // bi mozela da ja poednostavam i da kreiram dictionary so string i itn shto bi me poshtedelo mnogu linii kod ama ke ja zavrsham kako shto sum ja pocnala
                                        for (; ; )
                                        {

                                            int chooseSubject3 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter a grade from 6 to 10 or 5 for failed");
                                            int grade = int.Parse(Console.ReadLine());


                                            switch (chooseSubject3)
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
                                        #endregion

                                        Student newStudent = new Student(memberId, fullName, age, userName2, pass, currentlyListening, gradesForSubjects);
                                        students.Add(newStudent);
                                        Console.Clear();
                                        Console.WriteLine($"You have succesfully added a new student {newStudent.FullName}  that currently listents to {newStudent.CurrentlyListening}");
                                        Console.WriteLine("Current Grades");


                                        foreach (var item in gradesForSubjects)
                                        {
                                            Console.WriteLine($"Subject: {item.Key}| Grade: {item.Value} ");

                                        }


                                        break;

                                }


                            }
                            else if (nextMove == 2)
                            {
                                #region remove

                                Console.WriteLine("Choose:");
                                Console.WriteLine("1)Admin");
                                Console.WriteLine("2)Trainer");
                                Console.WriteLine("3)Student");
                                int remove = int.Parse(Console.ReadLine());

                                switch (remove)
                                {
                                    case 1:
                                        #region remove admins
                                        Console.Clear();
                                        admins.ForEach(x => Console.WriteLine($"{x.Id} | {x.FullName}"));
                                        for (; ; )
                                        {
                                            Console.WriteLine("Who would you like to remove? Enter member ID! Enter 0 to exit!");
                                            int removeById = int.Parse(Console.ReadLine());
                                            if (removeById == 0) break;
                                            else if (removeById == currentUser.Id)
                                            {
                                                Console.WriteLine("You can't remove yourself!");
                                                continue;
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                var removeAdmins = admins.Where(x => x.Id == removeById).FirstOrDefault();
                                                admins.Remove(removeAdmins);
                                                admins.ForEach(x => Console.WriteLine($"{x.Id} | {x.FullName}"));
                                                Console.WriteLine("You have succesfully removed an admin!");
                                                continue;

                                            }
                                        }
                                        #endregion
                                        break;
                                    case 2:
                                        #region remove trainers
                                        Console.Clear();
                                        trainers.ForEach(x => Console.WriteLine($"{x.Id} | {x.FullName}"));
                                        for (; ; )
                                        {
                                            Console.WriteLine("Who would you like to remove? Enter member ID! Enter 0 to exit!");
                                            int removeById = int.Parse(Console.ReadLine());
                                            if (removeById == 0) break;
                                            else
                                            {
                                                Console.Clear();

                                                var removeTrainers = trainers.Where(x => x.Id == removeById).FirstOrDefault();
                                                trainers.Remove(removeTrainers);
                                                trainers.ForEach(x => Console.WriteLine($"{x.Id} | {x.FullName}"));
                                                Console.WriteLine("You have succesfully removed a trainer!");
                                                continue;

                                            }
                                        }
                                        #endregion
                                        break;
                                    case 3:
                                        #region remove students
                                        Console.Clear();
                                        students.ForEach(x => Console.WriteLine($"{x.Id} | {x.FullName}"));
                                        for (; ; )
                                        {
                                            Console.WriteLine("Who would you like to remove? Enter member ID! Enter 0 to exit!");
                                            int removeById = int.Parse(Console.ReadLine());
                                            if (removeById == 0) break;
                                            else
                                            {
                                                Console.Clear();

                                                var removeStudents = students.Where(x => x.Id == removeById).FirstOrDefault();
                                                students.Remove(removeStudents);
                                                students.ForEach(x => Console.WriteLine($"{x.Id} | {x.FullName}"));
                                                Console.WriteLine("You have succesfully removed a student!");
                                                continue;

                                            }
                                        }
                                        #endregion
                                        break;
                                    default:
                                        Console.WriteLine("No such option! Try again!");
                                        break;

                                }
                                #endregion

                            }

                            else if (nextMove == 3) break;
                            else
                            {
                                Console.WriteLine("No such option");
                                continue;
                            }

                            #endregion
                        }
                        else if (currentUser.Role == AcademyRoles.Trainer)
                        {


                            #region trainer login

                            Console.WriteLine("----------------------");
                            Console.WriteLine("What is your next step?");
                            Console.WriteLine("1)See Students");
                            Console.WriteLine("2)See Subjects");
                            Console.WriteLine("3)Log Out");
                            Console.WriteLine("----------------------");
                            int nextMove = int.Parse(Console.ReadLine());


                            if (nextMove == 1)
                            {
                                #region see students
                                Console.Clear();

                                students.ForEach(x => Console.WriteLine($"{x.Id}) {x.FullName}"));
                                Console.WriteLine("----------------------");
                                Console.WriteLine("What is your next step?");
                                Console.WriteLine("1)Choose to check a student's file");
                                Console.WriteLine("2)Back to the Main Page");
                                Console.WriteLine("3)Log Out");
                                Console.WriteLine("----------------------");
                                int moveTwo = int.Parse(Console.ReadLine());
                                if (moveTwo == 1)
                                {


                                    while (true)
                                    {
                                        Console.WriteLine("Enter the ID of the Student whose file you would like to open!");
                                        int studentID = int.Parse(Console.ReadLine());
                                        Dictionary<Subjects, Grades> studentsGrades = Class1.ChecksStudent(students, studentID);
                                        if (studentsGrades != null)
                                        {
                                            Console.Clear();

                                            foreach (var item in studentsGrades)
                                            {
                                                Console.WriteLine($"Subject: {item.Key}  Grade: {item.Value}");
                                            }


                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Student with such ID number doesn't exist! Try Again!");
                                            continue;
                                        }
                                    }





                                    Console.ReadLine();


                                }
                                else if (moveTwo == 2)
                                {
                                    continue;
                                }
                                else if (moveTwo == 3)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Try again!");
                                    continue;
                                }

                                #endregion
                            }
                            else if (nextMove == 2)
                            {
                                #region see subjects
                                Console.Clear();
                                List<Subject> listOfSubjectAttendance = Class1.CheckAttendance(subjectsInTheAcademy, students);

                                foreach (Subject subject in listOfSubjectAttendance)
                                {
                                    if (subject.Attendance == 1)
                                    {
                                        Console.WriteLine($"{subject.NameOfSubject} is attented by {subject.Attendance} student");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{subject.NameOfSubject} is attented by {subject.Attendance} students");
                                    }

                                }
                                Console.ReadLine();

                                #endregion

                            }
                            else if (nextMove == 3)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No such option!");
                                continue;

                            }

                            #endregion
                        }
                        else if (currentUser.Role == AcademyRoles.Student)
                        {
                            #region student menu
                            Student currentlyLoggedIn = students.Where(x => x.Id == currentUser.Id).FirstOrDefault();
                            Console.WriteLine($"{currentlyLoggedIn.FullName} currently listens to {currentlyLoggedIn.CurrentlyListening}.");

                            Dictionary<Subjects, Grades> listOfGrades = Class1.ChecksStudent(students, currentUser.Id);
                            foreach (var item in listOfGrades)
                            {
                                Console.WriteLine($"Subject: {item.Key}  Grade: {item.Value}");
                            }

                            Console.WriteLine("Enter 0 to log out!");
                            int logOutOfStudentAccount = int.Parse(Console.ReadLine());
                            if (logOutOfStudentAccount == 0)
                                break;

                            #endregion
                        }



                        
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
