using System;

namespace Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Domashna od class03-exercise6");

            Console.WriteLine("Enter a name: ");
            string nameOne = Console.ReadLine();
            int counter = 1;
            int nameCount = 2;

            string[] nameArray = new string[1];

            nameArray[0] = nameOne;

            for (; ; )
            {
                Console.WriteLine("Would you like to enter another name? Answer with Y or N");
                string answer = Console.ReadLine().ToUpper();


                if (answer == "Y" )
                {
                    Array.Resize(ref nameArray, nameArray.Length +1);
                    Console.WriteLine("Enter " + nameCount + " name: ");
                    nameArray[counter] = Console.ReadLine();
                    counter++;
                    

                } else if (answer == "N" )
                {
                    Console.WriteLine("You entered N and I'm writing down all the names");
                    for (int i = 0; i < nameArray.Length; i++)
                    {
                        Console.WriteLine(nameArray[i]);
                    }
                    break;
                } else
                {
                    Console.WriteLine("No such command");
                };

                



            };
        }
    }
}
