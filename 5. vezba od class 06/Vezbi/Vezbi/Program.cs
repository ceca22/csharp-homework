using System;

namespace Vezbi
{
    class Program
    {
        #region  user REGISTER
        static User Register(User[] users)
        {

            System.Random random = new System.Random();
            int randomNum = random.Next(1000, 1500);
            int userId = randomNum;
            foreach (User item in users)
            {
                while(item.Id == userId) 
                {
                    randomNum = random.Next(1000, 1500);
                    userId = randomNum;
                }
            }
            //ovoj loop ima cel da proveri dali vo nizata postoi user so generiraniot broj na id 
            //za da ne kreira 2 useri so ist ID number
            Console.WriteLine($"Member Id is: {userId}");
            

            Console.WriteLine("Enter you username:");
            string usernameOfUser = Console.ReadLine();

            while (usernameOfUser.Length < 5)
            {
                Console.WriteLine("Username should be longer than 4 characters and contain numbers!");
                usernameOfUser = Console.ReadLine();
            };


            Console.WriteLine("Enter password:");
            string passOfUser = Console.ReadLine();
            while (passOfUser.Length < 6)
            {
                Console.WriteLine("Password should be longer than 5 characters!");
                passOfUser = Console.ReadLine();
            }

            string[] newMsg = new string[] { };

            User newRegUser = new User(userId, usernameOfUser, passOfUser, newMsg);
            return newRegUser;

        }

        #endregion


        #region LOGIN
        static User Login(User[] users)
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
                    } else
                    {
                        Console.WriteLine("Your messages:");
                        for (int i = 0; i < item.Messages.Length; i++)
                        {


                            Console.WriteLine($"{i + 1}:{item.Messages[i]}");


                        }
                    }

                    return curentUser;
                }
                
            }
            if (curentUser == null)
            {
                Console.WriteLine("No such user");
            }

            

            return curentUser;
        }


        #endregion



        

        static void Main(string[] args)
            {

            User[] usersRegister = new User[]
               {
                new User(4321, "Terry33", "mydog3", new string[]{"Hi Terry! How are you?", "I couldn't talk when you called", "Let me know when you wake up" }),
                new User(4322, "AnnieLove", "lovemylife5", new string[]{ "Call me when you see this!", "It was nice talking to you" }),
                new User(4323, "Denis994", "075271hi", new string[]{ "You are awesome" })

               };

            

            User[] newUsers = new User[]
            {

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

                        Console.WriteLine("Press h to return to HOME PAGE!");
                        string goBack = Console.ReadLine();

                        while (goBack != "h")
                        {
                        Console.WriteLine("Press h to return to HOME PAGE!");
                        goBack = Console.ReadLine();
                        }


                }
                else if (answer == "register")
                    {
                        User newUser = Register(usersRegister);
                        Array.Resize(ref usersRegister, usersRegister.Length + 1);
                        usersRegister[usersRegister.Length - 1] = newUser;
                        Console.Clear();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine($"You have succesfully registered {newUser.Username}!");

                        Console.WriteLine("---------------Registered users---------------------------");
                        foreach (User item in usersRegister)
                        {
                            Console.WriteLine($"Id:{item.Id}, username:{item.Username}");
                        }

                        Console.WriteLine("Press h to return to HOME PAGE!");
                        string goBack = Console.ReadLine();

                        while (goBack != "h")
                        {
                        Console.WriteLine("Press h to return to HOME PAGE!");
                        goBack = Console.ReadLine();
                        }
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

