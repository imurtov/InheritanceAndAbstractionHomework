using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Classes
{
	public class Developer : RegularEmpoyee, IEmployee, IDeveloper
	{
		private List<Projects> projects;

		public Developer(int id, string firstName, string lastName, double salary, string departament, List<Projects> projects) : base(id, firstName, lastName, salary, departament)
		{
			this.projects = new List<Projects>();
			this.AddProject(projects);
			
		}

		public void AddProject(List<Projects> projects)
		{
			foreach (var project in projects)
			{
				this.projects.Add(project);
			}

		}

		public override string ToString()
		{
			StringBuilder developerData = new StringBuilder();
			developerData.Append("Developer id: " + this.Id + ", Developer name: " + this.FirstName + " " + this.LastName + ", Developer salary: " + string.Format("{0:F2}", this.Salary) + ", Departament: "+ this.Departament +"\r\n");

			foreach (var project in this.projects)
			{
				developerData.Append(project + "\r\n");
			}

			return developerData.ToString();
		}
	}
}
