﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Interfaces
{
	interface IPerson
	{
		int Id { get; set; }

		string FirstName { get; set; }

		string LastName { get; set; }
	}
}
