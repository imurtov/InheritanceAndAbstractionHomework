using System;
using System.Text.RegularExpressions;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Classes
{
	public abstract class Person : IPerson
	{
		private int id;
		private string firstName;
		private string lastName;
		private static readonly string namePattern = @"[a-zA-Z_-]{2,}";

		public Person(int id, string firstName, string lastName)
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public int Id
		{
			get { return this.id; }
			set
			{
				try
				{
					if (value > 0)
					{
						this.id = value;
					} else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (OverflowException)
				{
					Console.WriteLine("{0} is not a valid number!");
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid id! Id cannot be 0 or a negative number!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid id!");
				}
			}
		}

		public string FirstName
		{
			get { return this.firstName; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
					{
						if (value.Length >= 2 && value.Length <= 32)
						{
							Match match = Regex.Match(value, namePattern);
							if (match.Success)
							{
								this.firstName = value;
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
					Console.WriteLine("Invalid first name! Name cannot be empty!");
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid first name! First name should be between 2 and 32 characters!");
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid first name! First name cannot contain numbers or any special characters!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid first name!");
				}
			}
		}

		public string LastName
		{
			get { return this.lastName; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
					{
						if (value.Length >= 2 && value.Length <= 32)
						{
							Match match = Regex.Match(value, namePattern);
							if (match.Success)
							{
								this.lastName = value;
							}
							else
							{
								throw new FormatException();
							}
						}
						else
						{
							throw new ArgumentOutOfRangeException();
						}
					}
					else
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("Invalid last name! Name cannot be empty!");
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid last name! Last name should be between 2 and 32 characters!");
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid last name! Last name cannot contain numbers or any special characters!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid last name!");
				}
			}
		}

		public override string ToString()
		{
			return string.Format("Person Id: {0}, Persona name: {1} {3}", this.Id, this.FirstName, this.LastName);
		}
	}
}
