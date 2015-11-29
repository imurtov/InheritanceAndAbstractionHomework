using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Classes
{
	public class RegularEmpoyee : Employee
	{
		public RegularEmpoyee(int id, string firstName, string lastName, double salary, string departament) : base(id, firstName, lastName, salary, departament)
		{

		}

		public override string ToString()
		{
			return string.Format("Employee Id: {0}, Employee name: {1} {2}, Employee salary: {3:F2}, Departament: {4}", this.Id, this.FirstName, this.LastName, this.Salary, this.Departament);
		}
	}
}
