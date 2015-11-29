using System;

namespace _03.CompanyHierarchy.CustomExceptions
{
	public class MonthOutOfRangeException : FormatException
	{
		public MonthOutOfRangeException() { }

		public MonthOutOfRangeException(string message) : base(message) { }

		public MonthOutOfRangeException(string message, FormatException inner) : base(message, inner) { }
	}
}
