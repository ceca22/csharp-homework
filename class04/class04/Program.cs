using System;

namespace class04
{
    class Program
    {



        static void FunWithString ( string stringInput)
        {
        
            
            
            Console.WriteLine("Input: " + stringInput);


            Console.WriteLine("----------------------------1.Print the reversed string------------------------------------");


            char[] reverseInput = stringInput.ToCharArray();
            Console.WriteLine("After converting to an array");
            Console.WriteLine(reverseInput.GetType());

            Console.WriteLine("Reversing the array:");
            Array.Reverse(reverseInput);
            Console.WriteLine(reverseInput);

           
            char[] reverseInputTwo = stringInput.ToCharArray();
            


            Console.WriteLine("----------------------------2.Check if string is Palindrome------------------------------------");


            string checkPalindrome;

            checkPalindrome = new string(reverseInput);
            bool b = stringInput.Equals(checkPalindrome, StringComparison.OrdinalIgnoreCase);

            if (b==true)
            {
                Console.WriteLine("The String is a palindrome");
            } else
            {
                Console.WriteLine("The String is not a palindrom");

            }



            Console.WriteLine("----------------------------3.Print total of vowels------------------------------------");
            int countVowels = 0;
            foreach (char input in reverseInputTwo)
            {
                if (input == 'e' || input == 'i' || input == 'o' || input == 'o' || input == 'u' || input == 'a' || input == 'y')
                {
                    countVowels++;
                }
                else continue;
            }

            Console.WriteLine($@"Total number of vowels:   {countVowels}");


            Console.WriteLine("----------------------------4.Print the count of words, smallest and largest word also------------------------------------");

            string[] countWords = stringInput.Split();
            Console.WriteLine("WordCountdown: " + countWords.Length + " words");
           

            
            int newCountForLargest = 0;
            string largestWord = "random";


            foreach (string count in countWords)
            {

                if (count.Length > newCountForLargest)
                {
                    newCountForLargest = count.Length;
                    largestWord = count;

                }
                else if (count.Length == newCountForLargest)
                {
                    largestWord += " and " + count;
                    
                }
            }


            
            int newCountForSmallest = newCountForLargest;

            //zoshto ne mozam da deklariram string bez vrednost na ovoj nacin -> string smallestWord; 
            //koga go deklariram na ovoj nacin bez vrednost podole kade shto go konzologiram mi pokazuva greshka
            //ne moze da pocne kodot bez inicijalna vrednost
            //isto i za largestWord
            
            string smallestWord = "none";

            //ne gi svrzav ovie dva foreach lopovi zatoa shto mi treba da zavrshi prviot foreach i da se zacuva
            //dolzinata na najdolgiot zbor pa spored negovata dolzina se ispolnuva najprviot uslovot vo if na
            //vtoriot forEach
            

            foreach (string count in countWords)
            {

                if (count.Length < newCountForSmallest)
                {
                    newCountForSmallest = count.Length;
                    smallestWord = count;
                } else if(count.Length == newCountForSmallest && count != largestWord)
                    //validacija za dokolku vneseme eden zbor da ne se isprinta i kaj largest i smallest
                {
                    smallestWord += " and " + count;
                    
                }
                
            }

            Console.WriteLine("Largest word:");
            Console.WriteLine(largestWord);

            Console.WriteLine("Smallest word:");
            Console.WriteLine(smallestWord);


            Console.WriteLine("----------------------------4.Print the most used charachter------------------------------------");

            
            //isto i ovde ne mozam da deklariram prazen char mostUsed

            int countFour = 0;
            char mostUsed = 'x';
            

            foreach (char input in reverseInputTwo)
            {
                string[] splitting = stringInput.Split(input);

                if (splitting.Length > countFour)
                {
                    countFour = splitting.Length;
                    mostUsed = input;

                }
                

            }

            Console.WriteLine(@$"Most used character is:{mostUsed} for {countFour - 1} times");




        }



        static void Main(string[] args)
        {
            //Create a new method called FunWithStrings that will have one input parameter (string) and it will have no return
            //In that method you should display in console the following tasks for the string:
            //print the reverse string-doneeeeeeeeeeeeeeeeeeeeeeee
            //print total number of vowels-doneeeeeeeeeeeeeeeeeeeeeeeee
            //check if string is palindrome-doneeeeeeeeeeeeeee
            //print the largest word-doneeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
            //print the smallest word-doneeeeeeeeeeeeeeeeeeeeeeeeeeeeee
            //print the count of words-doneeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
            //print the most used character (not space obviously)-doneeeeeeeeeeeeeeeeee
            //Ask the user to enter a string and call the method with that string.


            Console.WriteLine("Enter a string");

            FunWithString(Console.ReadLine());

        }
    }
}
