using System;
using System.Text.RegularExpressions;

namespace _01.HumanStudentAndWorker
{
	public abstract class Human
	{
		private static readonly string namePattern = @"[a-zA-Z_-]{2,}";

		private string firstName;
		private string lastName;

		public Human(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		} 

		public string FirstName
		{
			get { return this.firstName; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value))
					{
						if (!(value.Length > 2 && value.Length < 32))
						{
							throw new ArgumentOutOfRangeException();
						}
						else
						{
							Match match = Regex.Match(value, namePattern);
                            if (!match.Success)
							{
								throw new FormatException();
							} else
							{
								this.firstName = value;
							}
						}
					}
					else
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentOutOfRangeException)
				{

					Console.WriteLine("Invalid first name! Name should be longer than 2 characters and no longer than 32 characters!");
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid first name! Name cannot contain numbers!");
				} catch(ArgumentNullException)
				{
					Console.WriteLine("Invalid first name! First name cannot be empty!");
				}catch(Exception)
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
					if (!string.IsNullOrEmpty(value))
					{
						if (!(value.Length > 2 && value.Length < 32))
						{
							throw new ArgumentOutOfRangeException();
						}
						else
						{
							Match match = Regex.Match(value, namePattern);
							if (!match.Success)
							{
								throw new FormatException();
							}
							else
							{
								this.lastName = value;
							}
						}
					}
					else
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentOutOfRangeException)
				{

					Console.WriteLine("Invalid last name! Last name should be longer than 2 characters and no longer than 32 characters!");
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid last name! Last name cannot contain numbers!");
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("Invalid last name! Last name cannot be empty!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid last name!");
				}
			}
		}
	}
}
