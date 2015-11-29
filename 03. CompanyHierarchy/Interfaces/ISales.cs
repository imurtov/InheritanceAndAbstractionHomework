using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Interfaces
{
	interface ISales
	{
		string ProductName { get; set; }
		DateTime Date { get; set; }
		Double Price { get; set; }
	}
}
