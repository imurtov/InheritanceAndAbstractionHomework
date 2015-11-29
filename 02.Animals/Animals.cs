using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Animals.Classes;
using _02.Animals.Interfaces;

namespace _02.Animals
{
	class Animals
	{
		static void Main()
		{
			Frog f1 = new Frog("Billy", 0.2, "m");
			Dog d1 = new Dog("Liza", 4, "f");
			Cat c1 = new Cat("Kotaksi", 2, "m");
			Kitten k1 = new Kitten("Raya", 1);
			Tomcat t1 = new Tomcat("Rijo", 2);

			f1.ProduceSound();
			d1.ProduceSound();
			c1.ProduceSound();
			k1.ProduceSound();
			t1.ProduceSound();

			Console.WriteLine();

			Animal[] animals = new Animal[]
			{
				new Frog("Billy", 0.2, "m"),
				new Dog("Liza", 4, "f"),
				new Cat("Kotaksi", 2, "m"),
                new Kitten("Raya", 1),
                new Tomcat("Rijo", 2),
				new Frog("Pesho", 2.1, "f"),
				new Dog("Beti", 5.4, "f"),
				new Cat("Kotka", 2, "f"),
				new Kitten("Spaska", 4),
				new Tomcat("Gosho", 3),
				new Frog("Marmot", 4, "m"),
				new Tomcat("Bizen", 0.5),
				new Dog("India", 2.5, "f"),
			};

			animals.
				GroupBy(animal => animal.GetType().Name).
				Select(group => new
				{
					name = group.Key,
					averageYears = group.Average(animal => animal.Age)
				}).
				ToList().
				ForEach(group => Console.WriteLine("Group: {0}, average age: {1:F2} years!", group.name, group.averageYears));
		}
	}
}
