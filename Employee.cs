using System;
using System.Collections.Generic;

namespace EmployeeList
{
    public class Company
    {
        public string Name { get; }

        public DateTime DateFounded { get; }

        public List<Employee> EmployeeList = new List<Employee>();

        public Company()
        {

        }

        public Company(string name, string date)
        {
            Name = name;
            DateFounded = Convert.ToDateTime(date);
        }

        public void ListEmployees()
        {
            foreach (var e in EmployeeList)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} has been working at {Name} as {e.Title} since {e.StartDate}");
            }
        }

        public void AddEmployee(Employee e)
        {
            EmployeeList.Add(e);
        }
    }
}