using System;

namespace ConsoleApp1
{

   
    class Program
    {


        static int SumInputs(int num1, int num2)
        {
            return num1 + num2;

        }

        static void SumOddNums(int num1, int sum)
        {
            if (num1 % 2 != 0)
            {
                sum += + num1;
                Console.WriteLine(sum);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            bool number1 = int.TryParse(Console.ReadLine(), out int inputOne);
            Console.WriteLine("Input number:");
            bool number2 = int.TryParse(Console.ReadLine(), out int inputTwo);

            Console.WriteLine("The sum of " + inputOne + " and " + inputTwo + " is " + SumInputs(inputOne,inputTwo));
            Console.WriteLine("--------------------2 exercise--------------");
            for(; ; )
            {
               Console.WriteLine("Input a number or enter 000 to exit");
                int inputNum = int.Parse(Console.ReadLine());
                int sumOfOddNums = 0;
                SumOddNums(inputNum, sumOfOddNums);
                if (inputNum == 000) break;
            }
            Console.WriteLine("--------------------3 exercise--------------");

            //            Write a program to calculate the sum of all odd
            //two - digit numbers.The program prints the amount on the screen in the
            // format: 11 + 13 + 15 + 17 + ... +97 + 99 = 2475



        }
    }
}
