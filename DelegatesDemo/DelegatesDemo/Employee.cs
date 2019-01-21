using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesDemo
{
    class Employee : IComparable<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Employee other)
        {
            return FirstName.CompareTo(other.FirstName);
        }
    }
}
