using System;

namespace ForthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a number is divisable by 3 or 5");
            bool userEntry = int.TryParse(Console.ReadLine(), out int userInput);


            if ((userInput % 3 == 0) && (userInput % 5 == 0))
            {
                Console.WriteLine("Tik-Tak");
            }
            else if (userInput % 3 == 0)
            {
                Console.WriteLine("Tik");
            }
            else if (userInput % 5 == 0)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Bad number");
            }



            string name = Console.ReadLine();
        }
    }
}
