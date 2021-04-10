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
                if (user.UserName.ToLower() == username.ToLower() && user.Password == password && user.Removed != true) return user;
            }
            return null;
        }

        static Employee FindEmployee(Employee[] employees, string username, string password)
        {
            foreach (Employee employee in employees)
            {
                if (employee.UserName.ToLower() == username.ToLower() && employee.Password == password )
                {
                    
                    return employee;
                }
                    
            }
            return null;
        }
        static User LogAppUser(User[] users, string username, string password, Movie[] movies)
        {
            User currentlyLoggedInUser = FindUser(users, username, password);
            if (currentlyLoggedInUser != null)
                Console.WriteLine($"You have succesfully logged in {currentlyLoggedInUser.FirstName} {currentlyLoggedInUser.LastName}");
            else return null;
            Console.WriteLine("---------------------------------------------");
            currentlyLoggedInUser.Displayinfo();
            Console.WriteLine(currentlyLoggedInUser.Subscription);
            Console.WriteLine("-------------------Rented Movies------------");
            if(currentlyLoggedInUser.Movies.Length < 0)
            {
                Console.WriteLine("No movies rented at the moment");
            }
            else
            {
                for(int i=0; i< currentlyLoggedInUser.Movies.Length; i++)
                {
                    Console.WriteLine(currentlyLoggedInUser.Movies[i]);
                }
            }
            
            return currentlyLoggedInUser;


        }

        static string RentMoviesForUser( Movie[] movies)
        {
            Console.WriteLine("");
            Console.WriteLine("-----------Which movie would you like to rent?-----");
            foreach (Movie movie in movies)
            {
                if (movie.Rented != true)
                {
                    Console.WriteLine($"Title: {movie.Title} | Year: {movie.Year} | {movie.Genre} ");
                    Console.WriteLine("");
                }

            }
            Console.WriteLine("Enter the movie Title");
            string rentMovie = Console.ReadLine();
            string movieRented = null;
            foreach (Movie movie in movies)
            {
                if (rentMovie == movie.Title)
                {
                    movie.Rented = true;
                    movieRented = movie.Title;
                }


            }
            return movieRented;
        }

        static void LogAppEmployee(Employee[] employees, string username, string password, User[] users, Movie[] movies)
        {
            Employee currentlyLoggedIn = FindEmployee(employees, username, password);
            if (currentlyLoggedIn != null)
                Console.WriteLine($"You have succesfully logged in {currentlyLoggedIn.FirstName} {currentlyLoggedIn.LastName}");
            else return;

            Console.WriteLine("----------Registered users-----------");
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Removed != true)
                    users[i].Displayinfo();
                else continue;
            }
            Console.WriteLine("----------Registered employees-----------");
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Displayinfo();
            }

            Console.WriteLine("----------Movies available for rent-----------");
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rented == false)
                {
                    Console.WriteLine(movies[i].Title);
                } else if(movies[i].Rented == true)
                {
                    Console.WriteLine($"{movies[i].Title} is rented");
                }
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
            
            Employee newEmployee = new Employee(first, last, age, username, pass, phone, dateReg, role, hours);


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


            
            User newUser = new User(first, last, age, username, pass, phone, dateReg, MovieStoreRole.User, memberId, method, new string[] { } );
            return newUser;
        }

        static void RemoveUsers(User[] users)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            foreach (User user in users)
            {
                if (user.Removed != true)
                    user.Details();
                else continue;
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Who would you like to remove? Enter yes or no to start or stop removing");
            string toRemove = null;
            
            while(toRemove == "yes")
            {
                Console.WriteLine("Enter the member ID!");
                int removeUser = int.Parse(Console.ReadLine());
                
                foreach (User user in users)
                {
                    if (removeUser == user.MemberId)
                        user.Removed = true;
                    else continue;

                }
            }
            
        }




        static void Main(string[] args)
        {

            Employee[] arrayOfEmployees = new Employee[]
            {
                  new Employee("Anita", "Royal", 26, "ani555", "loveanita5", 075321321, new DateTime(2019,01,22), MovieStoreRole.Employee, 173)
            };

            User[] arrayOfUsers = new User[]
            {
                new User("Boni", "Bonita", 33, "bonii_2", "loveboni", 077456654, new DateTime(2020, 05, 15), MovieStoreRole.User, 6543, TypeOfSubscription.Monthly, new string[] { "Forrest Gump" })
            };


            Employee emloyee01 = new Employee("Anita", "Anoska", 26, "ani555", "loveanita5", 075321321, new DateTime(2019,01,22), MovieStoreRole.Employee, 173);
            User user01 = new User("Boni", "Bonita", 33, "bonii_2", "loveboni", 077456654, new DateTime(2020, 05, 15), MovieStoreRole.User, 6543, TypeOfSubscription.Monthly, new string[] { "Forrest Gump" });


            Movie[] arrayOfMovies = new Movie[]
            {
                new Movie("Forrest Gump", "Based on the 1986 novel of the same name by Winston Groom, however the film differs substantially from the novel.", 1994, MovieGenres.Drama, true),
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
                    Employee newReg = RegAppEmployee(arrayOfEmployees);
                    Array.Resize(ref arrayOfEmployees, arrayOfEmployees.Length + 1);
                    arrayOfEmployees[arrayOfEmployees.Length - 1] = newReg;

                }
                else if (answer == "login" || answer == "log in")
                {
                    Console.WriteLine("Are you a user or an employee?");
                    string memberKind = Console.ReadLine().ToLower();
                    if (memberKind == "user")
                    {
                        Console.WriteLine("------------Let's Log you into your account!------------");
                        Console.Write("Username: ");
                        string logUserName = Console.ReadLine().ToLower();

                        Console.Write("Password: ");
                        string logPassword = Console.ReadLine();
                        User currentuser = null;
                        currentuser = LogAppUser(arrayOfUsers, logUserName, logPassword, arrayOfMovies);
                        string currentRentedMovie = RentMoviesForUser(arrayOfMovies);
                        Array.Resize(ref currentuser.Movies, currentuser.Movies.Length + 1); 
                        currentuser.Movies[currentuser.Movies.Length + 1] = currentRentedMovie;

 

                    }
                    else if(memberKind == "employee")
                    {
                        Console.WriteLine("------------Let's Log you into your account!------------");
                        Console.Write("Username: ");
                        string logUserName = Console.ReadLine().ToLower();

                        Console.Write("Password: ");
                        string logPassword = Console.ReadLine();
                        Console.Clear();
                        
                        
                        LogAppEmployee(arrayOfEmployees, logUserName, logPassword, arrayOfUsers, arrayOfMovies);

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Would you like to add new users or delete any?");
                        string addOrDelete = Console.ReadLine().ToLower();
                        if (addOrDelete == "add")
                        {
                            User newUserReg = RegAppUser(arrayOfUsers);
                            Array.Resize(ref arrayOfUsers, arrayOfUsers.Length + 1);
                            arrayOfUsers[arrayOfUsers.Length - 1] = newUserReg;
                        } else if(addOrDelete == "delete")
                        {
                            RemoveUsers(arrayOfUsers);
                            

                        }
                        


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

