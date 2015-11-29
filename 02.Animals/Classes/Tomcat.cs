using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Classes
{
	class Tomcat : Cat
	{
		private static readonly string gender = "m";

		public Tomcat(string name, double age) : base(name, age, gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Miyauu!");
		}
	}
}
