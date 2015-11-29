using System;
using System.Text.RegularExpressions;
using _03.CompanyHierarchy.Interfaces;
using _03.CompanyHierarchy.CustomExceptions;

namespace _03.CompanyHierarchy.Classes
{
	public class Sales : ISales
	{
		private string productName;
		private DateTime date;
		private double price;

		public Sales(string productName, DateTime date, double price)
		{
			this.ProductName = productName;
			this.Date = date;
			this.Price = price;
		}

		public string ProductName
		{
			get { return this.productName; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
					{
						if (value.Length >= 2 && value.Length <= 32)
						{
							string pattern = @"^[A-Za-z0-9_\-\s]+$";
							Match match = Regex.Match(value, pattern);
							if(match.Success)
							{
								this.productName = value;
							} else
							{
								throw new FormatException();
							}
						} else
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
					Console.WriteLine("Invalid product name! Product name cannot be empty!");
				}
				catch(ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid product name! Product name should be between 2 and 10 characters!");
				}
				catch(FormatException)
				{
					Console.WriteLine("Invalid product name! Product name cannot contain any special characters!");
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid product name!");
				}
			}
		}

		public DateTime Date
		{
			get { return this.date; }
			set
			{
				try
				{
					if (value.Year >= 2000 && value.Year <= 2015)
					{
						if (value.Month >= 1 && value.Month <= 12)
						{
							if(value.Month % 2 != 0 && (value.Day >= 1 && value.Day <= 31))
							{

							} else if(value.Month == 2 && (value.Day >= 1 && value.Day <= 28))
							{

							} else if((value.Month != 2 && value.Month % 2 ==0) && (value.Day >= 1 && value.Day <= 30))
							{
								this.date = new DateTime(value.Year, value.Month, value.Day);
							}
							else
							{
								throw new DayOutOfRangeException();
							}
						} else
						{
							throw new MonthOutOfRangeException("Invalid date! Month must be in range 1 to 12");
						}
					}
					else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid date! Year must be in range 2000 to 2015!");
				}
				catch(MonthOutOfRangeException)
				{
					Console.WriteLine("Invalid date! Month must be in range 1 to 12");
				}
				catch(DayOutOfRangeException)
				{
					Console.WriteLine("Invalid date! The day for month {0} is not valid!", value.Month);
				}
				catch(IndexOutOfRangeException)
				{
					Console.WriteLine("Invalid date!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid date!");
				}
			}
		}

		public double Price
		{
			get { return this.price; }
			set
			{
				try
				{
					if (value >= 0)
					{
						this.price = value;
					}
					else
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid price! Price cannot be a negative number!");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Invalid price! {0} is not a valid number!", value);
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid price!");
				}
			}
		}

		public override string ToString()
		{
			return string.Format("Product name: {0}, Date: {1:dd.MM.yyyy}, Price: {2}", this.ProductName, this.Date, this.Price);
		}
	}
}
