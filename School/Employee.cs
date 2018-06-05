using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	abstract class Employee: Person {

		public int EmployeeId { get; set; }
		public decimal Salary { get; private set; }
		public string JobTitle { get; set; }

		public void SetSalary(decimal NewSalary) {
			if (NewSalary <= 0) {
				throw new ApplicationException("Salary must be positive");
			}
			Salary = NewSalary;
		}

		public Employee(string Name, string Email, string Phone, string JobTitle, decimal Salary) : base(Name, Email, Phone, true) {
			SetSalary(Salary);
			this.JobTitle = JobTitle;
		}

		public Employee () {

		}
	}
}

