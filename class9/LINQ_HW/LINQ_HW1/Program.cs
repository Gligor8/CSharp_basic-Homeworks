using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
	class Program
	{
        private static object x;

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
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

            // Task 01
            // all people aged 50 or more

            List<Person> aged50OrMore = people
                                        .Where(x => x.Age >= 50)
                                        .ToList();
            aged50OrMore.ForEach(x => Console.WriteLine(x.Age));

            // Task 02
            // all people name starts with B
            List<Person> NamesStartingWithB = people
											.Where(x => x.FirstName == "B")
											.ToList();
            Console.WriteLine(NamesStartingWithB);



			// Task 03
			// first person whose surname starts with T
			Person FirstPStartingWithT = people
											.Where(x => x.FirstName == "B")
											.First();
											
			Console.WriteLine(FirstPStartingWithT);


			// Task 04
			// find youngest and oldest person

			Person youngestPerson = people
							.FirstOrDefault(x => x.Age == people.Select(x => x.Age).Min());

			Person oldestPerson = people
							.FirstOrDefault(x => x.Age == people.Select(x => x.Age).Max());
            Console.WriteLine($"The youngest person is {youngestPerson}, while the oldest one is {oldestPerson}");

			// Task 05
			// find all male people aged 45 or more

			Person MenOver45 = people
				.Select(x => x.Age >= 45)
				.Where(x => x.Gender = 'M');
            Console.WriteLine(MenOver45);



			// Task 06
			// find all females whose name starts with V

			Person WomenWithV = people
				.Where(x => x.FirstName.StartsWith("V"))
				.Where(x => x.Gender == 'F')
				.toList();
            Console.WriteLine(WomenWithV);

			// Task 07
			// find last female person older than 30 whose name starts with p
			List<Person> Woman30P = people
							.Select(x => x.Age > 30)
							.Select(x => x.FirstName.StartsWith("p"))
							.Where(x => x.Gender == 'F')
							.ToList();
            Console.WriteLine(Woman30P);

			// Task 08
			// find first male younger than 40
			List<Person> MenYoungerThan40 = people
				.Where(x => x.Age < 40)
				.Where(x => x.Gender == 'M')
				.First()
				.toList();
            Console.WriteLine(MenYoungerThan40);
			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			List<Person> MaleNamesLongerThatLastNames = people
				.Where(x => x == 'M')
				.Where(x => x.FirstName.Length > x.LastName.Length)
				.toList();
            Console.WriteLine(MaleNamesLongerThatLastNames);
			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			List<Person> FemaleOddNumAges = people
				.Where(x => x.Age % 2 == 0)
				.Where(x => x.Gender == 'F')
				.ToList();
                Console.WriteLine(FemaleOddNumAges);
			Console.ReadLine();
		}
	}
}