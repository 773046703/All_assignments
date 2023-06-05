using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_الثامن_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string inputString = Console.ReadLine();

            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine("Reversed string: ");
            foreach (char c in charArray)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
