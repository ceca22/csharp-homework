using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[5]
            {
                "Cecilia",
                "Nicole",
                "Tina",
                "Ciarra",
                "Lola"
            };

            string[] studentsG2 = new string[5]
           {
                "David",
                "Nico",
                "Tatiana",
                "Carmen",
                "Luc"
           };

            Console.WriteLine("Enter a number between 1 or 2: ");
            bool answer = int.TryParse(Console.ReadLine(), out int answerInput);
            int counter = 1;

            if (answerInput == 1)
            {
                Console.WriteLine("You entered 1 and I'm printing the students in group G1");
                foreach(string name in studentsG1)
                {
                    
                    Console.WriteLine(counter + "." + name);
                    counter += 1;
                }


                //for (int i = 0; i < studentsG1.Length; i++)
                //{
                //    Console.WriteLine(studentsG1[i]);
                //}

            }
            else if (answerInput == 2)
            {
                Console.WriteLine("You entered 2 and I'm printing the students in group G2");

                foreach(string name in studentsG2)
                {
                    Console.WriteLine(counter + "." + name);
                    counter += 1;
                }
                //for (int i = 0; i < studentsG2.Length; i++)
                //{
                //    Console.WriteLine(studentsG2[i]);
                //}
            }
            else
            {
                Console.WriteLine("No such group");
            }




        }
    }
}
