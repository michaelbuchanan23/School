using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Sales : Employee {

		public decimal TotalSales { get; set; }
		public string Region { get; set; }
		public decimal Quota { get; set; }

		public Sales(string Name, string Email, string Phone, string JobTitle, decimal Salary, string Region, decimal Quota)
				: base(Name, Email, Phone, JobTitle, Salary) {
			this.Region = Region;
			this.Quota = Quota;
			this.TotalSales = 0;
		}

		public Sales() {

		}
	}
}
