using System;
using System.Linq;
using System.Text.RegularExpressions;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Classes
{
	public class Employee : Person, IEmployee
	{
		private readonly string[] departaments = new string[]
		{
			"Production",
			"Accounting",
			"Sales",
			"Marketing",
		};
		private double salary;
		private string departament;

		public Employee(int id, string firstName, string lastName, double salary, string departament) : base(id, firstName, lastName)
		{
			this.Salary = salary;
			this.Departament = departament;
		}

		public double Salary
		{
			get { return this.salary; }
			set
			{
				try
				{
					if (value > 0)
					{
						this.salary = value;
					} else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (OverflowException)
				{
					Console.WriteLine("Invalid salary! {0} is not a valid number!", value);
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid salary! Salary cannot be 0 or a negative number!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid salary!");
				}
			}
		}

		public string Departament
		{
			get { return this.departament; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
					{
						string departamentPattern = @"[A-Z]{1}[a-z]+";
						Match match = Regex.Match(value, departamentPattern);
						if (match.Success)
						{
							int index = Array.IndexOf(departaments, value);

							if (index >= 0)
							{
								this.departament = value;
							} else
							{
								throw new IndexOutOfRangeException();
							}
						} else
						{
							throw new FormatException();
						}
					} else
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentNullException)
				{

					Console.WriteLine("Invalid departament! Departament cannot be empty!");
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid departament! Departament cannot contain numbers or any special characters and should be in format e.x. \"Departament\"");
				}
				catch (IndexOutOfRangeException)
				{
					Console.WriteLine("Invalid departament! No such departament in this company!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid departament!");
				}
			}
		}

		public override string ToString()
		{
			return string.Format("Employee Id: {0}, Employee name: {1} {2}, Employee salary: {3:F2}, Departament: {4}", this.Id, this.FirstName, this.LastName, this.Salary, this.Departament);
		}
	}
}
