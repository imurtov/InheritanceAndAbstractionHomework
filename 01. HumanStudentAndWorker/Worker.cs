using System;

namespace _01.HumanStudentAndWorker
{
	public class Worker : Human
	{
		private double weekSalary;
		private double workHoursPerDay;

		public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerday = workHoursPerDay;
		}

		public double WeekSalary {
			get { return this.weekSalary; }
			set
			{
				try
				{
					if (value <= 0)
					{
						throw new ArgumentOutOfRangeException();
					}
					else
					{
						this.weekSalary = value;
					}
				}
				catch (ArgumentOutOfRangeException)
				{

					Console.WriteLine("Invalid salary! Salary cannot be a negative number");
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid salary!");
				}
			}
		}

		public double WorkHoursPerday
		{
			get { return this.workHoursPerDay; }
			set
			{
				try
				{
					if (value <= 0)
					{
						throw new ArgumentOutOfRangeException();
					}
					else
					{
						this.workHoursPerDay = value;
					}
				}
				catch (ArgumentOutOfRangeException)
				{

					Console.WriteLine("Invalid hours! The hours cannot be a negative number");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid salary!");
				}
			}
		}

		public double MoneyPerHour()
		{
			double payment = this.WeekSalary / (5 * this.WorkHoursPerday);

			return payment;
		}

		public override string ToString()
		{
			return string.Format("Worker: {0} {1}, payment per hour: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
		}

	}
}
