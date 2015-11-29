using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Classes
{
	public class SalesEmployee : RegularEmpoyee, ISalesEmployee
	{
		private List<Sales> sales;

		public SalesEmployee(int id, string firstName, string lastName, double salary, string departament, List<Sales> sales) : base(id, firstName, lastName, salary, departament)
		{
			this.sales = new List<Sales>();
			this.AddSale(sales);
		}

		public void AddSale(List<Sales> sales)
		{
			foreach (var sale in sales)
			{
				this.sales.Add(sale);
			}
		}

		public override string ToString()
		{
			StringBuilder employeeData = new StringBuilder();

			employeeData.Append("SalesEmployee Id: " + this.Id + ", SalesEmpployee name: " + this.FirstName + " " + this.LastName + "SalesEmployeeSalary: " + string.Format("{0:F2}", this.Salary) + ", Departament: " + this.Departament + "\r\n");

			foreach (var sale in this.sales)
			{
				employeeData.Append(sale + "\r\n");
			}

			return employeeData.ToString();
		}
	}
}
