using MovieStoreLibrary.Enums;
using MovieStoreLibrary.Models;
using System;

namespace MovieStore

{


    class Program
    {

        #region FIND USER
        static User FindUser(User[] users, string username, string password)
        {
            foreach (User user in users)
            {
                if (user.UserName.ToLower() == username.ToLower() && user.Password == password && user.Removed != true) return user;
            }
            return null;
        }
        #endregion

        #region FIND EMPLOYEEE
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

#endregion


        #region LOGIN EMPLOYEES
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

#endregion

        #region REGISTER employess


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

            Console.Write("Enter you telephone number: ");
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
#endregion





        #region REGISTER USERS
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
            Console.Write("Enter telephone number: ");
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

            while (paymentMethod != 1 || paymentMethod != 2)
            {
                Console.Write("Enter 1 for monthly or 2 for yearly: ");
                paymentMethod = int.Parse(Console.ReadLine());
                if (paymentMethod == 1)
                {
                    method = TypeOfSubscription.Monthly;
                    break;
                }
                   
                else if (paymentMethod == 2)
                {
                    method = TypeOfSubscription.Yearly;
                    break;
                }
                    
            }

            if (paymentMethod == 1)
                method = TypeOfSubscription.Monthly;
            else if (paymentMethod == 2)
                method = TypeOfSubscription.Yearly;




            User newUser = new User(first, last, age, username, pass, phone, dateReg, MovieStoreRole.User, memberId, method, new Movie[] { } );
            return newUser;
        }
        #endregion

        #region LOGIN USERS

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
            if (currentlyLoggedInUser.Movies.Length == 0)
            {
                Console.WriteLine("No movies rented at the moment");
            }
            else
            {
                for (int i = 0; i < currentlyLoggedInUser.Movies.Length; i++)
                {
                    Console.WriteLine(currentlyLoggedInUser.Movies[i].Title);
                }
            }

            return currentlyLoggedInUser;


        }

        #endregion

        #region RENT MOVIES FOR USERS

        static Movie RentMoviesForUser(Movie[] movies)
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
            Movie movieRented = null;

            for (; ; )
            {
                Console.WriteLine("Enter the movie Title");
                string rentMovie = Console.ReadLine();
                movieRented = null;

                for (int i = 0; i < movies.Length; i++)
                {

                    if (rentMovie == movies[i].Title)
                    {
                        movies[i].Rented = true;
                        movieRented = movies[i];
                        break;
                    }
                }


                break;

               
            }
            
            
            return movieRented;
        }
        #endregion

        #region Remove USERS
        static void RemoveUsers(User[] users, Movie[] movies)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            foreach (User user in users)
            {
                if (user.Removed != true)
                    user.Details(movies);
                else continue;
            }
            Console.WriteLine("-------------------------------");

            string toRemove = null;
            Console.WriteLine("Who would you like to remove? Enter yes or no to start or stop removing");
            toRemove = Console.ReadLine();

            while (toRemove == "yes")
            {
                Console.WriteLine("Enter the member ID!");
                int removeUser = int.Parse(Console.ReadLine());

                foreach (User user in users)
                {
                    if (removeUser == user.MemberId)
                        user.Removed = true;
                    else continue;

                }

                Console.WriteLine("Who would you like to remove? Enter yes or no to start or stop removing");
                toRemove = Console.ReadLine();
                if (toRemove != "yes") break;
                

            }

            return;

        }



        #endregion

        static void Main(string[] args)
        {
            Movie[] arrayOfMovies = new Movie[]
           {
                new Movie("Forrest Gump", "Based on the 1986 novel of the same name by Winston Groom, however the film differs substantially from the novel.", 1994, MovieGenres.Drama, true),
                new Movie("The Shawshank Redemption", "The title refers to Andy's escape, as well as a shout out to one of the ways he makes life bearable in prison.", 1994, MovieGenres.Drama, false),
                new Movie("American Psycho", "Based on American Psycho by Bret Easton Ellis", 2000, MovieGenres.Thrillers, false),
                new Movie("Catch Me If You Can", "The film is based on the life of Frank Abagnale, who, before his 19th birthday, successfully performed cons worth millions of dollars by posing as a Pan American World Airways pilot, a Georgia doctor and a Louisiana parish prosecutor.", 2002, MovieGenres.Comedy, false),
                new Movie("Transformers", "The Transformers toyline and animated series were inspired by the Japanese toyline, Microman (an Eastern descendant of the 12-inch G.I. Joe action figure series) by Takara", 2007, MovieGenres.Action, false),
                new Movie("Inside Out", "One of the main lessons of 'Inside Out' is about how contradictory emotions can work in concert. The movie centers on an 11-year-old girl named Riley, whose life goes through big changes when her family moves from Minnesota to San Francisco.", 2015, MovieGenres.Animated, false )
           };

            Employee[] arrayOfEmployees = new Employee[]
            {
                  new Employee("Anita", "Royal", 26, "ani555", "loveanita5", 075321321, new DateTime(2019,01,22), MovieStoreRole.Employee, 173)
            };

            User[] arrayOfUsers = new User[]
            {
                new User("Boni", "Bonita", 33, "bonii_2", "loveboni", 077456654, new DateTime(2020, 05, 15), MovieStoreRole.User, 6543, TypeOfSubscription.Monthly, new Movie[] {arrayOfMovies[0] }),
                new User("Lola", "Lolita", 26, "lolaa_2", "lovelola", 078333211, new DateTime(2020, 07, 10), MovieStoreRole.User, 6544, TypeOfSubscription.Yearly, new Movie[] {}),
                new User("Coca", "Cola", 26, "cocaa_2", "lovecoca", 078333515, new DateTime(2020, 07, 10), MovieStoreRole.User, 6545, TypeOfSubscription.Yearly, new Movie[] {})

            };

            
            for(; ; )
                
            {
                Movie[] newRentedMovies = new Movie[] { };

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

                        User currentuser = LogAppUser(arrayOfUsers, logUserName, logPassword, arrayOfMovies);

                        User currentlyLoggedInUser = FindUser(arrayOfUsers, logUserName, logPassword);


                        if (currentlyLoggedInUser != null)
                        {
                            Console.WriteLine("Would you like to rent a movie?");
                            string rentOrNot = Console.ReadLine();

                            while (rentOrNot == "yes")
                            {
                                Movie currentlyRented = RentMoviesForUser(arrayOfMovies);
                                newRentedMovies = currentlyLoggedInUser.Movies;
                                Array.Resize(ref newRentedMovies, newRentedMovies.Length + 1);
                                newRentedMovies[newRentedMovies.Length - 1] = currentlyRented;

                                string message = $"{currentlyLoggedInUser.FirstName} {currentlyLoggedInUser.LastName} has rented";


                                for (int i = 0; i < newRentedMovies.Length; i++)
                                {

                                    if (i == newRentedMovies.Length - 1)
                                    {
                                        message += $" {newRentedMovies[i].Title}.";
                                    }
                                    message += $" {newRentedMovies[i].Title},";
                                };

                                currentlyLoggedInUser.Movies = newRentedMovies;

                                Console.WriteLine(message);
                                Console.WriteLine("Would you like to rent a movie?");
                                rentOrNot = Console.ReadLine();
                            }

                            if (rentOrNot == "no") continue;
                            else Console.WriteLine("Invalid input");


                        }

                        else
                        {
                            Console.WriteLine("No such user!");
                        }

                    }
                    else if (memberKind == "employee")
                    {
                        Console.WriteLine("------------Let's Log you into your account!------------");
                        Console.Write("Username: ");
                        string logUserName = Console.ReadLine().ToLower();

                        Console.Write("Password: ");
                        string logPassword = Console.ReadLine();
                        Console.Clear();


                        LogAppEmployee(arrayOfEmployees, logUserName, logPassword, arrayOfUsers, arrayOfMovies);
                        Employee currentlyLoggedIn = FindEmployee(arrayOfEmployees, logUserName, logPassword);

                        if (currentlyLoggedIn != null)
                        {

                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Would you like to add new users or delete any? Enter 'h' to go back to the HOME Page!");
                            string addOrDelete = Console.ReadLine().ToLower();

                            while (addOrDelete != "h")
                            {
                                
                                if (addOrDelete == "add")
                                {
                                    User newUserReg = RegAppUser(arrayOfUsers);
                                    Array.Resize(ref arrayOfUsers, arrayOfUsers.Length + 1);
                                    arrayOfUsers[arrayOfUsers.Length - 1] = newUserReg;
                                    Console.WriteLine($"You have successfully registered {newUserReg.FirstName} {newUserReg.FirstName}");
                                    Console.WriteLine("Would you like to add new users or delete any? Enter 'h' to go back to the HOME Page!");
                                    addOrDelete = Console.ReadLine().ToLower();
                                    if (addOrDelete == "add") continue;
                                }
                                else if (addOrDelete == "delete")
                                {
                                    RemoveUsers(arrayOfUsers, newRentedMovies);
                                    Console.WriteLine("Would you like to add new users or delete any? Enter 'h' to go back to the HOME Page!");
                                    addOrDelete = Console.ReadLine().ToLower();
                                    continue;

                                }

                            }
                        }

                        else
                        {
                            Console.WriteLine("No such user");
                        }





                    }
                }
            }


            






            }

        }
    }

