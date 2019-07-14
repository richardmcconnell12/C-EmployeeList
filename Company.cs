using System;

namespace EmployeeList
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public Employee()
        {

        }

        public Employee(string firstname, string lastname, string title, string date)
        {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            StartDate = Convert.ToDateTime(date);
        }

    }
}