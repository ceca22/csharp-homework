using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Richardson", 58, 'F' ),
			new Person("Elena","Parker", 68, 'F' ),
			new Person("Mort","Mar", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

            // Task 01
            // all people aged 50 or more
            Console.WriteLine("-----------------aged 50 or more------------");
			List<Person> aged50 = people
								.Where(x => x.Age >= 50)
								.ToList();

			aged50.ForEach(x => Console.WriteLine($"{x.FirstName} | Age: {x.Age}"));


			// Task 02
			// all people name starts with B
			Console.WriteLine("-----------------name starts with B------------");

			List<Person> nameStartsWithB = people
										.Where(x => x.FirstName.StartsWith("B"))
										.ToList();

			nameStartsWithB.ForEach(x => Console.WriteLine(x.FirstName));


			// Task 03
			// first person whose surname starts with T
			Console.WriteLine("-----------------first person surname starts with T------------");

			Person surnameStartsWithT = people
									.Where(x => x.LastName.StartsWith("T"))
									.First();

            Console.WriteLine(surnameStartsWithT.LastName);

			// Task 04
			// find youngest and oldest person
			Console.WriteLine("-----------------youngest and oldest------------");


			List<int> peopleAge = people
								.Select(x => x.Age)
								.ToList();
			
			peopleAge.Sort();


            int youngest = peopleAge
                            .First();

			Person youngestPerson = people
								.Where(x => x.Age == youngest)
								.First();

            Console.WriteLine($"Youngest: {youngestPerson.FirstName} | Age: {youngestPerson.Age}");



            var oldest = peopleAge
                            .Last();

			Person oldestPerson = people
								.Where(x => x.Age == oldest)
								.First();

            Console.WriteLine($"Oldest: {oldestPerson.FirstName} | Age: {oldestPerson.Age}");


			// Task 05
			// find all male people aged 45 or more
			Console.WriteLine("-----------------males age 45 or above------------");


			List<Person> malePeople = people
							.Where(x => x.Gender == 'M')
							.Where(x => x.Age >= 45)
							.ToList();
			malePeople.ForEach(x => Console.WriteLine($"{x.FirstName} | gender: {x.Gender}  | Age 45 or above: {x.Age}"));

			// Task 06
			// find all females whose name starts with V
			Console.WriteLine("-----------------females names that start with V------------");

			List<Person> females = people
							.Where(x => x.Gender == 'F')
							.Where(x => x.FirstName.StartsWith("V"))
							.ToList();
			females.ForEach(x => Console.WriteLine(x.FirstName));


			// Task 07
			// find last female person older than 30 whose name starts with p
			//nema takva zena,zatoa ke go resham so bukvata E, dodadov ushte edna zena-Elena nad 30
			Console.WriteLine("-------------last female person older than 30 whose name starts with E(changed by me) ------------");

			Person lastFemaleOlderThan30 = people
											.Where(x => x.Gender == 'F')
											.Where(x => x.Age > 30)
											.Where(x => x.FirstName.StartsWith("E"))
											.Last();

            Console.WriteLine(lastFemaleOlderThan30.FirstName);


			// Task 08
			// find first male younger than 40

			Console.WriteLine("-------------first male younger than 40 ------------");

			Person firstMaleYoungerThan40 = people
										.Where(x => x.Gender == 'M')
										.Where(x => x.Age < 40)
										.First();

            Console.WriteLine(firstMaleYoungerThan40.FirstName);

			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			Console.WriteLine("-------------names of the male persons that have firstName longer than lastName ------------");
			//izmeniv edno od preziminjata na mazite inaku prazna beshe listata

			List<Person> males = people
								.Where(x => x.Gender == 'M')
								.Where(x => x.FirstName.Length > x.LastName.Length)
								.ToList();

			males.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));


            // Task 10
            // print the lastNames of the female persons that have odd number of ages
            Console.WriteLine("-------------lastNames of the female persons that have odd number of ages ------------");

			List<Person> femalesfemales = people
								.Where(x => x.Gender == 'F')
								.Where(x => x.Age % 2 == 0)
								.ToList();

			femalesfemales.ForEach(x => Console.WriteLine($"{x.LastName} Age: {x.Age}"));


			Console.ReadLine();
		}
    }
}
