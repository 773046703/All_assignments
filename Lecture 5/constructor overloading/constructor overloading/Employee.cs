using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading
{
    class Employee
    {
        private string name;
        private int salary;
        private string address;

        public Employee() : this("Unknown", 30000, "Mukalla")
        {
            Console.WriteLine("Welcome to our company");
        }

        public Employee(string name) : this(name, 30000, "Mukalla") { }

        public Employee(string name, int salary) : this(name, salary, "Mukalla") { }

        public Employee(string name, int salary, string address)
        {
            this.name = name;
            this.salary = salary;
            this.address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Address: {address}");
        }
    }
}

