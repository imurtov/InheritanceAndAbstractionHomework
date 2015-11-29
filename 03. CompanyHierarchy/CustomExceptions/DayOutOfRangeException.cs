using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.CustomExceptions
{
	public class DayOutOfRangeException : FormatException
	{
		public DayOutOfRangeException() { }

		public DayOutOfRangeException(string message) : base(message) { }

		public DayOutOfRangeException(string message, FormatException inner) : base(message, inner) { }
	}
}
