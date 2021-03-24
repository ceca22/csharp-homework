using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool first = int.TryParse(Console.ReadLine(), out int firstInput);
            bool second = int.TryParse(Console.ReadLine(), out int secondInput);
            bool third = int.TryParse(Console.ReadLine(), out int thirdInput);
            bool forth = int.TryParse(Console.ReadLine(), out int forthInput);

            Console.WriteLine("The first input is: " + firstInput);
            Console.WriteLine("The second input is: " + secondInput);
            Console.WriteLine("The third input is: " + thirdInput);
            Console.WriteLine("The forth input is: " + forthInput);

            if(first && second && third && forth)
            {
                int averageNumber = (firstInput + secondInput + thirdInput + forthInput) / 4;
                Console.WriteLine("The average of " + firstInput + "," + secondInput + "," + thirdInput + " and " + forthInput + " is: " + averageNumber);
            } else
            {
                Console.WriteLine("Invalid input!");
            }
            
        }
    }
}
