using System;

namespace Vezbi
{
    class Program
    {



        static void Register(User[] users)
        {
            Console.WriteLine("ID number:");
            int idOfUser = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you username:");
            string usernameOfUser = Console.ReadLine();
            while (usernameOfUser.Length < 5)
            {
                Console.WriteLine("Username should be longer than 5 characters and contain numbers!");
                usernameOfUser = Console.ReadLine();
            };
            Console.WriteLine("Enter password:");
            string passOfUser = Console.ReadLine();
            while (passOfUser.Length < 5)
            {
                Console.WriteLine("Password should be longer than 5 characters!");
                passOfUser = Console.ReadLine();
            }
            string[] newArray = new string[] { };



            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User(idOfUser, usernameOfUser, passOfUser, newArray);
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"You have succesfully registered {users[users.Length - 1].Username}!");

            Console.WriteLine("---------------Registered users---------------------------");
            foreach (User item in users)
            {
                Console.WriteLine($"Id:{item.Id}, username:{item.Username}");
            }




        }

        static void Login(User[] users)
        {

            Console.WriteLine("----------------Log In--------------");
            Console.Write("Enter you username: ");
            string usernameOfUser = Console.ReadLine();
            Console.Write("Enter password: ");
            string passOfUser = Console.ReadLine();
            User curentUser = null;

            foreach (User item in users)
            {

                if (item.Username == usernameOfUser && item.Password == passOfUser)
                {
                    Console.Clear();
                    curentUser = item;
                    Console.WriteLine($"Welcome to your page {item.Username}");
                    if (item.Messages.Length == 0)
                    {
                        Console.WriteLine("You have no messages");
                    }
                    for (int i = 0; i < item.Messages.Length; i++)
                    {

                        Console.WriteLine("Your messages:");
                        Console.WriteLine($"{i + 1}:{item.Messages[i]}");


                    }
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Enter log out when u want to log out");
                    string logOut = Console.ReadLine().ToLower();
                    if (logOut == "logout" || logOut == "log out")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        while (logOut != "logout" || logOut != "log out")
                        {
                            Console.WriteLine("No such command, try again!");
                            Console.ReadLine();
                        }

                    }

                }
                }

                if (curentUser == null)
                {
                    Console.WriteLine("No such user");
                }


            }
            static void Main(string[] args)
            {
                User[] usersRegister = new User[]
                {
                new User(4321, "Terry33", "mydog3", new string[]{"Hi Terry! How are you?", "I couldn't talk when you called", "Let me know when you wake up" }),
                new User(4322, "AnnieLove", "lovemylife5", new string[]{ "Call me when you see this!", "It was nice talking to you" }),
                new User(4323, "Denis994", "075271hi", new string[]{ "You are awesome" })
                };


                /*
               Creata a program that will represent User Login and Register functionality
               - The User should have two options : 
                   1) Log in 
                   2) Register
               - Class User: Id, Username, Password, Messages
               - If a user is successfully logged in, it should show his messages
                   e.g. Your messages: "his message here"
               - Note: Provide basic Login and Register validation
               */

                // TO DO:
                // 1. Class
                // 2. Login & register methods
                // 3. Instantiate objects in an array
                // 4. UI

                for (; ; )
                {
                    Console.WriteLine("Hi there!I hope you are doing well!");
                    Console.WriteLine("Would you like to LOG IN or REGISTER?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "log in" || answer == "login")
                    {
                        Login(usersRegister);

                    }
                    else if (answer == "register")
                    {
                        Register(usersRegister);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Try Again");
                    }

                    Console.WriteLine("---------------------------------");
                }
            }
        }
    }

