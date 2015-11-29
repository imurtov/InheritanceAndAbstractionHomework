using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Classes;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
	class Hierarchy
	{
		static void Main(string[] args)
		{
			Manager manager = new Manager
				(1,
				 "Ivan",
				 "Murtov",
				 3500,
				 "Accounting",
				 new List<RegularEmpoyee>()
				 {
					 new RegularEmpoyee(2, "Martin", "Venelinov", 1000d, "Sales"),
					 new RegularEmpoyee(3, "Radosting", "Mokanov", 1000d, "Sales")
				 });

			Developer developer = new Developer
				(2, 
				"Ivan",
				"Ivanchev",
				8000d,
				"Production",
				new List<Projects>()
				{
					new Projects("Project Prayer", new DateTime(2015, 12, 12), "Very cool project"),
					new Projects("project SPUP", new DateTime(2015, 12,11), "MRI project for AR")
				});

			List<Employee> employees = new List<Employee>();
			employees.Add(developer);
			employees.Add(manager);

			foreach (var employee in employees)
			{
				Console.WriteLine(employee);
			}
		}
	}
}
