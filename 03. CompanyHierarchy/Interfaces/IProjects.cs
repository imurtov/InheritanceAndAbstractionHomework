using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Interfaces
{
	interface IProjects
	{
		string ProjectName { get; set; }
		DateTime StartDate { get; set; }
		string Details { get; set; }
		string State { get; }
		void CloseProject();
	}
}
