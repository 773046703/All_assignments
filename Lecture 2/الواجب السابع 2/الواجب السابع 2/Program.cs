using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_السابع_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter a character to find its occurrence: ");
            char ch = Convert.ToChar(Console.ReadLine());

            int count = 0;

            foreach (char c in str)
            {
                if (c == ch)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of occurrences of '{0}' in '{1}' is {2}", ch, str, count);
            Console.ReadLine();
        }
    }
}
