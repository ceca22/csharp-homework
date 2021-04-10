using MovieStoreLibrary.Enums;
using MovieStoreLibrary.Models;
using System;

namespace MovieStore

{


    class Program
    {
        static User FindUser(User[] users, string username, string password)
        {
            foreach (User user in users)
            {
                if (user.UserName.ToLower() == username.ToLower() && user.Password == password) return user;
            }
            return null;
        }

        static Employee FindEmployee(Employee[] employees, string username, string password)
        {
            foreach (Employee employee in employees)
            {
                if (employee.UserName.ToLower() == username.ToLower() && employee.Password == password)
                {
                    Console.WriteLine($"You have succesfully logged in {employee.FirstName} {employee.LastName}");
                    return employee;
                }
                    
            }
            
        }
        static void LogAppUser()
        {

        }

        static void LogAppEmployee( User[] users, Movie[] movies)
        {
            
            Console.WriteLine("----------Registered users-----------");
            for (int i = 0; i < users.Length; i++)
            {
                users[i].Displayinfo();
            }
            Console.WriteLine("----------Movies available for rent-----------");
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rented == false)
                {
                    Console.WriteLine(movies[i].Title);
                }
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Would you like to add new users or delete any?");
            string addOrDelete = Console.ReadLine().ToLower();
            if(addOrDelete == "add")
            {
                RegAppUser(users);
            }
        }



        static Employee RegAppEmployee(Employee[] employees)
        {
            Console.Write("Enter you first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter you last name: ");
            string last = Console.ReadLine();
            Console.Write("Enter you age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter you username(must be more than 4 characters): ");
            string username = Console.ReadLine().ToLower();
            while (username.Length < 5)
            {
                Console.Write("Enter you username(must be more than 4 characters): ");
                username = Console.ReadLine();
            }
            Console.Write("Enter you password(must be more than 5 characters): ");
            string pass = Console.ReadLine();
            while (pass.Length < 6)
            {
                Console.Write("Enter you password(must be more than 5 characters): ");
                pass = Console.ReadLine();
            }
            Console.Write("Enter you telephone number(must be at least 9 digits): ");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Date of registration: ");
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            int date = int.Parse(Console.ReadLine());
            DateTime dateReg = new DateTime(year, month, date);

            //i am assuming that every employee registers in the app on his first day so hoursPerMonth == 0
            //and therefor no bonus
            int hours = 0;
            MovieStoreRole role = MovieStoreRole.Employee;
            Array.Resize(ref employees, employees.Length + 1);
            Employee newEmployee = employees[employees.Length - 1];
            newEmployee = new Employee(first, last, age, username, pass, phone, dateReg, role, hours);


            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"You have succefully registered {newEmployee.FirstName} {newEmployee.LastName}!");
            Console.WriteLine("Enter 'h' to go back to the HOME page!");
            string goBackToHome = Console.ReadLine();
            while(goBackToHome != "h")
            {
                Console.WriteLine("Enter 'h' to go back to the HOME page!");
                goBackToHome = Console.ReadLine();
            }
            

            return newEmployee;
        }

        static User RegAppUser(User[] users)
        {
            Console.Write("Enter first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter last name: ");
            string last = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Create username(must be more than 4 characters): ");
            string username = Console.ReadLine().ToLower();
            while (username.Length < 4)
            {
                Console.Write("Create username(must be more than 4 characters): ");
                username = Console.ReadLine();
            }
            Console.Write("Enter password(must be more than 5 characters): ");
            string pass = Console.ReadLine();
            while (pass.Length < 5)
            {
                Console.Write("Enter password(must be more than 5 characters): ");
                pass = Console.ReadLine();
            }
            Console.Write("Enter telephone number(must be at least 9 digits): ");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Date of registration: ");
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            int date = int.Parse(Console.ReadLine());
            DateTime dateReg = new DateTime(year, month, date);

            System.Random random = new System.Random();
            int randomNum = random.Next(1000, 1500);
            int memberId = randomNum;
            Console.WriteLine($"Member Id is: {memberId}");
            Console.WriteLine("Which payment method would you choose-Monthly or Yearly");
            Console.Write("Enter 1 for monthly or 2 for yearly: ");
            int paymentMethod = int.Parse(Console.ReadLine());
            TypeOfSubscription method = 0;
            if (paymentMethod == 1)
            {
                method = TypeOfSubscription.Monthly;
            }
            else if (paymentMethod == 2)
            {
                method = TypeOfSubscription.Yearly;
            }
            else if (paymentMethod != 1 || paymentMethod != 2)
            {
                while (paymentMethod != 1 || paymentMethod != 2)
                {
                    Console.Write("Enter 1 for monthly or 2 for yearly: ");
                    paymentMethod = int.Parse(Console.ReadLine());
                }
            }


            Array.Resize(ref users, users.Length + 1);
            User newUser = users[users.Length - 1];
            newUser = new User(first, last, age, username, pass, phone, dateReg, MovieStoreRole.User, memberId, method, new string[] { } );
            return newUser;
        }





        static void Main(string[] args)
        {

            Employee[] arrayOfEmployees = new Employee[]
            {
                  new Employee("Anita", "Royal", 26, "ani555", "loveanita5", 075321321, new DateTime(2019,01,22), MovieStoreRole.Employee, 173)
            };

            User[] arrayOfUsers = new User[]
            {
                new User("Boni", "Bonita", 33, "bonii_2", "loveboni", 077456654, new DateTime(2020, 05, 15), MovieStoreRole.User, 6543, TypeOfSubscription.Monthly, new string[] { "horror", "animated", "romance" })
            };


            Employee emloyee01 = new Employee("Anita", "Anoska", 26, "ani555", "loveanita5", 075321321, new DateTime(2019,01,22), MovieStoreRole.Employee, 173);
            User user01 = new User("Boni", "Bonita", 33, "bonii_2", "loveboni", 077456654, new DateTime(2020, 05, 15), MovieStoreRole.User, 6543, TypeOfSubscription.Monthly, new string[] { "horror", "animated", "romance" });


            Movie[] arrayOfMovies = new Movie[]
            {
                new Movie("Forrest Gump", "Based on the 1986 novel of the same name by Winston Groom, however the film differs substantially from the novel.", 1994, MovieGenres.Drama, false),
                new Movie("The Shawshank Redemption", "The title refers to Andy's escape, as well as a shout out to one of the ways he makes life bearable in prison.", 1994, MovieGenres.Drama, false),
                new Movie("American Psycho", "Based on American Psycho by Bret Easton Ellis", 2000, MovieGenres.Thrillers, false),
                new Movie("Catch Me If You Can", "The film is based on the life of Frank Abagnale, who, before his 19th birthday, successfully performed cons worth millions of dollars by posing as a Pan American World Airways pilot, a Georgia doctor and a Louisiana parish prosecutor.", 2002, MovieGenres.Comedy, false),
                new Movie("Transformers", "The Transformers toyline and animated series were inspired by the Japanese toyline, Microman (an Eastern descendant of the 12-inch G.I. Joe action figure series) by Takara", 2007, MovieGenres.Action, false),
                new Movie("Inside Out", "One of the main lessons of 'Inside Out' is about how contradictory emotions can work in concert. The movie centers on an 11-year-old girl named Riley, whose life goes through big changes when her family moves from Minnesota to San Francisco.", 2015, MovieGenres.Animated, false )
            };

            //emloyee01.Displayinfo();
            //Console.WriteLine($"{emloyee01.FirstName} {emloyee01.LastName} of age {emloyee01.Age} is an {MovieStoreRole.Employee} in our MovieStore");
            //Console.WriteLine($"Salary total before bonus:{emloyee01.SetSalary()} euros");
            //emloyee01.SetBonus();
            //Console.WriteLine($"Salary total after bonus:{emloyee01.SetSalary()} euros");
            //Console.WriteLine("-------------------------------------------------------------");

            //user01.Displayinfo();
            //Console.WriteLine($"{user01.FirstName} {user01.LastName} of age {user01.Age} is a {MovieStoreRole.User} in our MovieStore.");
            //Console.WriteLine(user01.showMovies());
            
            for(; ; )
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Welcome to our Movie Store App!");
                Console.WriteLine("Would you like to LOG IN or REGISTER(only employees)?");
                string answer = Console.ReadLine().ToLower();

                 if (answer == "register")
                 {
                    RegAppEmployee(arrayOfEmployees);

                 }
                else if (answer == "login" || answer == "log in")
                {
                    Console.WriteLine("Are you a user or an employee?");
                    string memberKind = Console.ReadLine().ToLower();
                    if (memberKind == "user")
                    {


                    }else if(memberKind == "employee")
                    {
                        Console.WriteLine("------------Let's Log you into your account!------------");
                        Console.Write("Username: ");
                        string logUserName = Console.ReadLine().ToLower();

                        Console.Write("Password: ");
                        string logPassword = Console.ReadLine();
                        Console.Clear();
                        FindEmployee(arrayOfEmployees, logUserName, logPassword);
                        
                        LogAppEmployee( arrayOfUsers, arrayOfMovies);
                        


                    } else if(memberKind != "user" || memberKind != "employee")
                    {
                        while(memberKind != "user" || memberKind != "employee")
                        {
                            Console.WriteLine("Are you a user or an employee?");
                            memberKind = Console.ReadLine().ToLower();
                        }
                    }
                } 
            }


            






            }

        }
    }

