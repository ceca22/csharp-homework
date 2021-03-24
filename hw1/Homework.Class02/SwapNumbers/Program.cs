using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool first = int.TryParse(Console.ReadLine(), out int firstInput);
            bool second = int.TryParse(Console.ReadLine(), out int secondInput);


            if(first && second)
            {
                Console.WriteLine("The first Input is: " + firstInput);
                Console.WriteLine("The second Input is: " + secondInput);

                Console.WriteLine("After swaping:");
                (firstInput, secondInput) = (secondInput, firstInput);

                Console.WriteLine("The first Input is: " + firstInput);
                Console.WriteLine("The second Input is: " + secondInput);
            } else
            {
                Console.WriteLine("Invalid entry!");
            }


        }
    }
}
