using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RealCalculator Project");
            Console.WriteLine("Enter a number!");
            bool first = int.TryParse(Console.ReadLine(), out int firstInput);
            Console.WriteLine("Enter a number!");
            bool second = int.TryParse(Console.ReadLine(), out int secondInput);
            Console.WriteLine("Choose an operation: +, -, /, * ");
            string operation = Console.ReadLine();
            int result;

            Console.WriteLine("The first input is:" + firstInput);
            Console.WriteLine("The first input is:" + secondInput);
            Console.WriteLine("The operation is:" + operation);

            if (first && second)
            {
                switch (operation)
                {
                    case "+":
                        result = firstInput + secondInput;
                        Console.WriteLine("The result is " + result + "(coming from switch)");
                        break;
                    case "-":
                        result = firstInput - secondInput;
                        Console.WriteLine("The result is " + result + "(coming from switch)");
                        break;
                    case "/":
                        result = firstInput / secondInput;
                        Console.WriteLine("The result is " + result + "(coming from switch)");
                        break;
                    case "*":
                        result = firstInput * secondInput;
                        Console.WriteLine("The result is " + result + "(coming from switch)");
                        break;
                    default:
                        Console.WriteLine("Invalid operation entry!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid entry");

            }


            //za vezbanje go napishav i so if


            if (first && second)
            {
                if (operation == "+")
                {
                    result = firstInput + secondInput;
                    Console.WriteLine("The result is " + result);
                }
                else if (operation == "-")
                {
                    result = firstInput - secondInput;
                    Console.WriteLine("The result is " + result);
                }
                else if (operation == "/")
                {
                    result = firstInput / secondInput;
                    Console.WriteLine("The result is " + result);
                }
                else if (operation == "*")
                {
                    result = firstInput * secondInput;
                    Console.WriteLine("The result is " + result);
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");

            }

        }
    }
}
