using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using _03.CompanyHierarchy.CustomExceptions;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Classes
{
	public class Projects : IProjects
	{
		private const string defaultProjectState = "open";

		private string projectName;
		private DateTime startDate;
		private string details;
		private string stte;

		public Projects(string projectName, DateTime startDate, string details)
		{
			this.ProjectName = projectName;
			this.StartDate = startDate;
			this.Details = details;
			this.State = defaultProjectState;
		}

		public string ProjectName
		{
			get { return this.projectName; }
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
							if (match.Success)
							{
								this.projectName = value;
							} else
							{
								throw new FormatException();
							}
						}else
						{
							throw new ArgumentOutOfRangeException();
						}
					}else
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("Invalid project name! Project name cannot be empty!");
				}
				catch(ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid project name! Project name should be between 2 and 32 characters!");
				}
				catch(FormatException)
				{
					Console.WriteLine("Invalid project name! Project name cannot contain any special characters!");
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid project name!");
				}
			}
		}

		public DateTime StartDate
		{
			get { return this.startDate; }
			set
			{
				try
				{
					if (value.Year >= 2015)
					{
						if (value.Month >= 1 && value.Month <= 12)
						{
							if (value.Month % 2 != 0 && (value.Day >= 1 && value.Day <= 31))
							{

							}
							else if (value.Month == 2 && (value.Day >= 1 && value.Day <= 28))
							{

							}
							else if ((value.Month != 2 && value.Month % 2 == 0) && (value.Day >= 1 && value.Day <= 30))
							{
								DateTime startDate = new DateTime(value.Year, value.Month, value.Day);
								if (startDate >= DateTime.Now)
								{
									this.startDate = startDate;
								} else
								{
									throw new ArgumentException();
								}
							}
							else
							{
								throw new DayOutOfRangeException();
							}
						}
						else
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
				catch (MonthOutOfRangeException)
				{
					Console.WriteLine("Invalid date! Month must be in range 1 to 12");
				}
				catch (DayOutOfRangeException)
				{
					Console.WriteLine("Invalid date! The day for month {0} is not valid!", value.Month);
				}
				catch (IndexOutOfRangeException)
				{
					Console.WriteLine("Invalid date!");
				}
				catch(ArgumentException)
				{
					Console.WriteLine("Invalid start date! You have entered a passed date!");
				}
				catch (Exception)
				{
					Console.WriteLine("Invalid date!");
				}
			}
		}

		public string Details
		{
			get { return this.details; }
			set
			{
				try
				{
					if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
					{
						if(value.Length >= 2 && value.Length <= 32)
						{
							string pattern = @"^[A-Za-z0-9_\-\s]+$";
							Match match = Regex.Match(value, pattern);
							if (true)
							{
								this.details = value;
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
					Console.WriteLine("Invalid details! Details cannot be empty");
				}
				catch(ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid details! Details must be at least 2 characters and no longer than 32 characters!");
				}
				catch(FormatException)
				{
					Console.WriteLine("Invalid details! Details cannot contain any special characters!");
				}
				catch(Exception)
				{
					Console.WriteLine("Invalid details");
				}
			}
		}

		public string State
		{
			get;
			private set;
		}

		public void CloseProject()
		{
			this.State = "closed";
		}

		public override string ToString()
		{
			return string.Format("Project name: {0}, Project start date: {1:dd.MM.yyyy}, Project details: {2}, Project state: {3}", this.ProjectName, this.StartDate, this.Details, this.State);
		}
	}
}
