using System;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number of points from 0 to 100");
            //bool points = int.TryParse(Console.ReadLine(), out int pointsOnExam);

            
            bool points = float.TryParse(Console.ReadLine(), out float pointsOnExam);

            if(pointsOnExam <= 50)
            {
                Console.WriteLine("You got a grade:5!");
            } else if(pointsOnExam <= 60)
            {

                Console.WriteLine("You got a grade:6!");

            } else if(pointsOnExam <= 70)
            {
                Console.WriteLine("You got a grade:7!");

            } else if(pointsOnExam <= 80)
            {
                Console.WriteLine("You got a grade:8!");

            } else if(pointsOnExam <= 90)
            {
                Console.WriteLine("You got a grade:9!");

            } else if (pointsOnExam <= 100)
            {
                Console.WriteLine("You got a grade:102!");

            }


        }
    }
}
