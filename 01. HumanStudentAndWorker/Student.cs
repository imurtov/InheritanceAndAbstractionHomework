using System;
using System.Text.RegularExpressions;

namespace _01.HumanStudentAndWorker
{
	public class Student : Human
	{
		private string facultyNumber;

		public Student(string firstName, string lastName, string facultyNumber) :base(firstName, lastName)
		{
			this.FacultyNumber = facultyNumber;
		}

		public string FacultyNumber
		{
			get { return this.facultyNumber; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value))
					{
						if (value.Length >= 5 && value.Length <= 10)
						{
							string facultyNumberPattern = @"^[a-zA-Z]{5,10}$|^[1-9]{1}\d{4,9}$";
							Match match = Regex.Match(value, facultyNumberPattern);
							if (match.Success)
							{
								this.facultyNumber = value;
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
				catch(ArgumentNullException)
				{
					Console.WriteLine("Invalid faculty number! Faculty number cannot be empty!");
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid faculty number! Faculty number must be sequence of at least 5 characters and no more than 10 characters.");
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid faculty number! Faculty number must be a sequence of letters only or numbers only. Faculty number cannot start with 0 (zero)!");
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid faculty number!");
				}
			}
		}

		public override string ToString()
		{
			return string.Format("Student: {0} {1}, Faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
		}
	}
}
