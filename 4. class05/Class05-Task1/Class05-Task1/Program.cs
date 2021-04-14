using System;

namespace Class05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            Console.WriteLine("-------Print the current date with time(ORIGINAL DATE)-----");
            Console.WriteLine(currentDate);
            Console.WriteLine("-----Print the date that is 10 years from now-------");
            DateTime addYears = currentDate.AddYears(10);
            Console.WriteLine(addYears);
            Console.WriteLine("-------Print the date that is 2 months and 15 days ago-------");

            DateTime subDaysAndMonths = currentDate.AddMonths(-2).AddDays(-15);
            Console.WriteLine(subDaysAndMonths);

            Console.WriteLine("---------Print day of week for the next 8 - th March------");
            DateTime eighthMarch = new DateTime(2022, 3, 8);
            
            string dayOfEight = eighthMarch.ToString("dddd, dd MM yyyy");
            Console.WriteLine(dayOfEight);

            Console.WriteLine("--------Print day of week of last year's Valentine's day------");
            DateTime lastYearValentine = new DateTime(2020, 2, 14);
            string dayOfValentine = lastYearValentine.ToString("dddd, dd MM yyyy");
            Console.WriteLine(dayOfValentine);



        }
    }
}
