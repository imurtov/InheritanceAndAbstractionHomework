using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Classes
{
	public class Manager : Employee, IEmployee, IManager
	{
		private List<RegularEmpoyee> setOfEmployees;

		public Manager(int id, string firstName, string lastName, double salary, string departament, List<RegularEmpoyee> setOfEmployees) : base(id, firstName, lastName, salary, departament)
		{
			this.setOfEmployees = new List<RegularEmpoyee>();
			this.AddEmployee(setOfEmployees);
		}


		public void AddEmployee(List<RegularEmpoyee> employees)
		{
			
			foreach (var employee in employees)
			{
				this.setOfEmployees.Add(employee);
			}
		}

		public override string ToString()
		{
			StringBuilder employeesData = new StringBuilder();
			employeesData.Append("Manager Id: " + this.Id + ", Manager Name: " + this.FirstName + " " + this.LastName + ", Manager Salaery: " + this.Salary + ", Departament: " + this.Departament + ", Employees:\r\n");
			foreach (var employee in this.setOfEmployees)
			{
				employeesData.Append(employee + "\r\n");
			}

			return employeesData.ToString();
		}
	}
}
