using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a PhoneBook Dictionary with 5 names and phone numbers.
            //    ●Through the console ask the person to enter a name.
            //    ●Try and find that names phone number in your PhoneBook
            //    ●If you can find it, print it in the console
            //    ●If you can’t, print an error message



            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                { "Ivana", "072111222" },
                { "Teodora", "075454545" },
                { "Stefan", "071232323" },
                { "Vasko", "077666000" },
                { "Marija", "072333444" }
            };

            Console.WriteLine("Hello from your phonebook! This is the search panel. Enter a name to find the wanted contact info or x to exit!");


            while (true)
            {
                string searchContacts = Console.ReadLine();
                phoneBook.ContainsKey(searchContacts);

                if (phoneBook.ContainsKey(searchContacts) == false)
                {
                    Console.WriteLine("No such contact found!");
                }


                foreach (var numb in phoneBook)
                {
                    if (numb.Key == searchContacts)
                    {
                        Console.WriteLine($"Contact: {numb.Key}, Phone number: { numb.Value.Substring(0, 3)}-{numb.Value.Substring(3, 3)}-{numb.Value.Substring(6)}");

                    }
                    
                }

                if (searchContacts == "x") break;
            }
            

            





        }
    }
}
