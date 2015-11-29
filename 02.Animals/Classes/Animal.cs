using System;
using System.Text.RegularExpressions;
using _02.Animals.Interfaces;

namespace _02.Animals.Classes
{
	public abstract class Animal : ISoundProducible
	{
		private string name;
		private string gender;
		private double age;

		public Animal(string name, double age, string gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public string Name
		{
			get { return this.name; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value))
					{
						if (value.Length >= 2 && value.Length <= 32)
						{
							string namePattern = @"^[A-Za-z_-]{2,32}$";
							Match match = Regex.Match(value, namePattern);
							if (match.Success)
							{
								this.name = value;
							} else
							{
								throw new FormatException();
							}
						}
						else
						{
							throw new ArgumentOutOfRangeException();
						}
					} else
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentNullException)
				{

					Console.WriteLine("Invalid name! Name cannot be empty!");
				}
				catch(ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid name! Name should contain at least 2 characters and no more than 32 characters!");
				}
				catch(FormatException)
				{
					Console.WriteLine("Invalid name! Name cannot contain numbers or any other special symboles!");
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid name!");
				}
			}
		}

		public double Age
		{
			get { return this.age; }
			set
			{
				try
				{
					if (value > 0)
					{
						this.age = value;
					} else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch(OverflowException)
				{
					Console.WriteLine("Invalid age! {0} is not a valid number!", value);
				}
				catch (ArgumentOutOfRangeException)
				{

					Console.WriteLine("Invalid age! Age cannot be zero or negative number!");
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid age!");
				}
			}
		}

		public string Gender
		{
			get { return this.gender; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
					{
						if (value.Length == 1)
						{
							string genderPattern = @"(^M$|^m$)|(^F$|^f$)";
							Match match = Regex.Match(value, genderPattern);
							if (true)
							{

							} else
							{
								throw new FormatException();
							}
						} else
						{
							throw new ArgumentOutOfRangeException();
						}
					} else
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentNullException)
				{

					Console.WriteLine("Invalid gender! Gender cannot be empty!");
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid gender! Gender should contain only 1 character!");
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid gender! Gender should contain only letter m/M or f/F!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid gender!");
				}
			}
		}

		public abstract void ProduceSound();
	}
}
