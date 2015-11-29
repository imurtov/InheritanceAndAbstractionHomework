using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.HumanStudentAndWorker
{
	class StudentsAndWorkers
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>()
			{
				new Student("Gosho", "Teamleader-a", "1234567890"),
				new Student("Trudnoto", "Momichence", "awerwfer"),
				new Student("Ivan", "Murtov", "12345"),
				new Student("Ivan", "Ivanchev", "123456"),
				new Student("Mokanin", "RadOstina", "AbCdEFgH"),
				new Student("Hristo", "Kirov", "1234567"),
				new Student("Petya", "Dimitrova", "12345678"),				
				new Student("Gosho", "Noviq", "abcdefg"),
				new Student("Coach", "Potatoe", "awergfawrg"),
				new Student("Tihomir", "Ivanov", "123456789"),
			};

			List<Student> sortedStrudents = students.OrderBy(student => student.FacultyNumber).ToList();

			foreach (var student in sortedStrudents)
			{
				Console.WriteLine(student);
			}
			Console.WriteLine();

			List<Worker> workers = new List<Worker>()
			{
				new Worker("Gosho", "Peshov", 50.6, 8.5),
				new Worker("Pesho", "Peshov", 40, 8),
				new Worker("Martin", "Venelinov", 100, 1),
				new Worker("Tahomi", "Sato", 45, 5.4),
				new Worker("Cvetan", "Vasilev", 80, 12.6),
				new Worker("Fidel", "Castro", 125.6, 7.1),
				new Worker("Veselin", "Marinov", 30.9, 8),
				new Worker("Geri", "Nikol", 250, 1.5),
				new Worker("Gentiana", "Haliti", 500, 1),
				new Worker("Fiki", "Storaro", 1000, 2),
			};

			List<Worker> sortedWorkers = workers.OrderBy(worker => - worker.MoneyPerHour()).ToList();
			foreach (var worker in sortedWorkers)
			{
				Console.WriteLine(worker);
			}
			Console.WriteLine();

			List<Human> combined = new List<Human>();

			combined.AddRange(students);
			combined.AddRange(workers);

			foreach (var human in combined.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
			{
				Console.WriteLine(human);
			}
			
		}
	}
}
