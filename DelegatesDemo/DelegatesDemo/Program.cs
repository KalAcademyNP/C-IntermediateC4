using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName="Fred",
                    LastName="Flintstone"
                },
                new Employee
                {
                    FirstName ="Barney",
                    LastName = "Rubble"
                }
            };

            employees.Sort();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            
        }
    }
}
