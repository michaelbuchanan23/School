using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Student : Person {

		private static int nextId = 1; //call nextId so we know that this is the number for the nextId so assign nextId then increment

		public bool IsVeteran { get; set; } = false;
		public int StudentId { get; set; }
		public double GPA { get; set; }

		public Student(string Name, string Email, string Phone, bool IsEmployee, bool IsVeteran, double GPA) : base(Name, Email, Phone, IsEmployee) {
			this.IsVeteran = IsVeteran;
			this.GPA = GPA;
		}

		public Student() {

		}
	}
}
