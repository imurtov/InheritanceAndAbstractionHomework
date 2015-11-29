using System;
using _03.CompanyHierarchy.Interfaces;
namespace _03.CompanyHierarchy.Classes
{
	public class Customer : Person, ICustomer
	{
		private double amountSpent;

		public Customer(int id, string firstName, string lastName, double amountSpent) : base(id, firstName, lastName)
		{
			this.AmountSpent = amountSpent;
		}

		public double AmountSpent
		{
			get { return this.amountSpent; }
			set
			{
				try
				{
					if (value > 0)
					{
						this.amountSpent = value;
					}
					else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (OverflowException)
				{
					Console.WriteLine("Invalid amount! {0} is not a valid number!", value);
				}
				catch(ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid amout! The amount cannot be 0 or a negative number!");
				}
			}
		}

		public override string ToString()
		{
			return string.Format("Customer id: {0}, Customer name: {1} {2}, Money spent: {3}", this.Id, this.FirstName, this.LastName, this.AmountSpent );
		}
	}
}
