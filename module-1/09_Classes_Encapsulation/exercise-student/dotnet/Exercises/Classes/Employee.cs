﻿namespace Exercises.Classes
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Department { get; set; }
        public double AnnualSalary { get; private set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public Employee (int employeeId, string firstName, string lastName, double salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = salary;
        }

        public void RaiseSalary (double percent)
        {
            AnnualSalary = AnnualSalary + (AnnualSalary * (percent / 100));
        }
    }
}
