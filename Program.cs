using System;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Company
            var Furever = new Company("Furever Friends Pet Shelter", "3/3/2012");

            // Create instances of 3 employees
            var Ricky = new Employee("Ricky", "McConnell", "CEO and Director of Operations", "3/3/2012");
            var Ashwin = new Employee("Ashwin", "Prakash", "On-hand Veterinarian", "4/6/2013");
            var Cass = new Employee("Cassidy", "Galentino", "Secretary", "6/4/2012");

            Furever.AddEmployee(Ricky);
            Furever.AddEmployee(Ashwin);
            Furever.AddEmployee(Cass);

            Furever.ListEmployees();
        }
    }
}
