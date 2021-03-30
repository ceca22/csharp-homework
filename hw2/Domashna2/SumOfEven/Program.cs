using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrayOne = new int[6];
            int sumOfEven = 0;

            for(int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                bool input = int.TryParse(Console.ReadLine(), out arrayOne[i]);
                if(arrayOne[i] % 2 == 0)
                {
                    sumOfEven += arrayOne[i];
                }
            }

            Console.WriteLine("First input is: " + arrayOne[0]);
            Console.WriteLine("Second input is: " + arrayOne[1]);
            Console.WriteLine("Third input is: " + arrayOne[2]);          
            Console.WriteLine("Forth input is: " + arrayOne[3]);            
            Console.WriteLine("Fifth input is: " + arrayOne[4]);            
            Console.WriteLine("Six input is: " + arrayOne[5]);           
            

            Console.WriteLine("The sum of even numbers is: " + sumOfEven);

        }
    }
}
