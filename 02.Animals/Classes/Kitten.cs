using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Classes
{
	class Kitten : Cat
	{
		private static readonly string gender = "f";

		public Kitten(string name, double age) : base(name, age, gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Miyauuuu!");
		}
	}
}
