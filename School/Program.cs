using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Program {
		static void Main(string[] args) {

			Student s1 = new Student("Dan", "dan@a.com", "1234", false, true, 4.9);
			Instructor i1 =
				new Instructor("U", "u@up.com", "9876", "Boot Camp Instructor", 10000, "CSharp");
			Sales sl1 =
				new Sales("Lisa", "lisa@maxtrain.com", "5555", "Sales", 150000, "US", 2000000);
			sl1.TotalSales = 23000.00M;
			Operations o1 =
				new Operations("Larry", "l@up.com", "4356", "SuperOp", 3000000);

			List<Person> people = new List<Person>();
			people.Add(s1);
			people.Add(i1);
			people.Add(sl1);
			people.Add(o1);

			Console.WriteLine("-----------------------------------------------------------------");

			foreach (Person person in people) {
				Console.WriteLine($"Name: \t\t{person.Name}\nEmail: \t\t{person.Email}\nPhone: \t\t{person.Phone}\nEmployee?: \t{person.IsEmployee}");
				Console.WriteLine("-----------------------------------------------------------------");
			}

			decimal totalSales = 0;
			foreach (Person person in people) {
				Sales sales = person as Sales; //this says take this instance above and turn it into a sales type -- if it can't do that then it will return null
				if (sales != null) {
					totalSales += sales.TotalSales;
				}
				
				//the below doesn't work --we had to use the "Sales sales = person as Sales;" line of code above to get this to work
				//if (person.GetType().Name == "Sales") { //"person.GetType().Name" returns a string
				//	totalSales += person.TotalSales;
			}
			Console.WriteLine($"Total Sales: \t${totalSales}");
		}
	}
}

