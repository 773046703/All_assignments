using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.PrintInfo();

            Employee emp2 = new Employee("John");
            emp2.PrintInfo();

            Employee emp3 = new Employee("Jane", 40000);
            emp3.PrintInfo();

            Employee emp4 = new Employee("Bob", 50000, "New York");
            emp4.PrintInfo();
        }
    }
}
