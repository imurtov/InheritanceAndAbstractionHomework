using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.Animals.Classes
{
	class Frog : Animal
	{
		public Frog(string name, double age, string gender ) : base(name, age, gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public override void ProduceSound()
		{
			Console.WriteLine("Kwack!");
		}
	}
}
