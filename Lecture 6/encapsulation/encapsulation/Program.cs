using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Enter First Name : ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Email : ");
            person.Email = Console.ReadLine();

            Console.WriteLine(person.GetFullName()); // Output: First Name + Lastb Name

            person.Print(); // Output: First Name + Lastb Name - Email
        }
    }
}
