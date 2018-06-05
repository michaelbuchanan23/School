using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Instructor : Employee {

		public string Technology { get; set; }
		public bool TeachBootCamps { get; set; } = false;

		public Instructor(string Name, string Email, string Phone, string JobTitle, decimal Salary, string Technology) : base(Name, Email, Phone, JobTitle, Salary) {
			this.Technology = Technology;
		}

		public Instructor() {

		}
	}
}
