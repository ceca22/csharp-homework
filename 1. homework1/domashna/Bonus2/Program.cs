using System;

namespace Bonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the previous program so that in addition to the grades, the + and - signs 
            // will be printed depending on the value of the last digit of the points:
            //last digit            print example
            // 1 - 3 - 81 = 9 -
            // 4 - 7(empty space)               94 = 10
            // 8 - 0 + 68 = 7 +


            Console.WriteLine("Enter a number of points from 0 to 100");
            bool points = int.TryParse(Console.ReadLine(), out int pointsOnExam);

            if (pointsOnExam <= 50)
            {
                Console.WriteLine("You got a grade:5!");

            }
            else if (pointsOnExam <= 60)
            {
                if (pointsOnExam > 50 && pointsOnExam < 54)
                {
                    Console.WriteLine("You got a grade:6-!");
                }
                else if (pointsOnExam > 53 && pointsOnExam < 58)

                {
                    Console.WriteLine("You got a grade:6!");

                }
                else if (pointsOnExam > 57 && pointsOnExam < 61)
                {
                    Console.WriteLine("You got a grade:6+!");

                }

            }
            else if (pointsOnExam <= 70)
            {
                if (pointsOnExam > 60 && pointsOnExam < 64)
                {
                    Console.WriteLine("You got a grade:7-!");
                }
                else if (pointsOnExam > 63 && pointsOnExam < 68)

                {
                    Console.WriteLine("You got a grade:7!");

                }
                else if (pointsOnExam > 67 && pointsOnExam < 71)
                {
                    Console.WriteLine("You got a grade:7+!");

                }

            }
            else if (pointsOnExam <= 80)
            {
                if (pointsOnExam > 70 && pointsOnExam < 74)
                {
                    Console.WriteLine("You got a grade:8-!");
                }
                else if (pointsOnExam > 73 && pointsOnExam < 78)

                {
                    Console.WriteLine("You got a grade:8!");

                }
                else if (pointsOnExam > 77 && pointsOnExam < 81)
                {
                    Console.WriteLine("You got a grade:8+!");

                }
            }
            else if (pointsOnExam <= 90)
            {
                if (pointsOnExam > 80 && pointsOnExam < 84)
                {
                    Console.WriteLine("You got a grade:9-!");
                }
                else if (pointsOnExam > 83 && pointsOnExam < 88)

                {
                    Console.WriteLine("You got a grade:9!");

                }
                else if (pointsOnExam > 87 && pointsOnExam < 91)
                {
                    Console.WriteLine("You got a grade:9+!");

                }
            }
            else if (pointsOnExam <= 100)
            {
                if (pointsOnExam > 90 && pointsOnExam < 94)
                {
                    Console.WriteLine("You got a grade:10-!");
                }
                else if (pointsOnExam > 93 && pointsOnExam < 98)

                {
                    Console.WriteLine("You got a grade:10!");

                }
                else if (pointsOnExam > 97 && pointsOnExam < 101)
                {
                    Console.WriteLine("You got a grade:10+!");

                }

            }

            


        }
    }
}
