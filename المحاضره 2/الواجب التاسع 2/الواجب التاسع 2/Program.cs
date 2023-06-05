using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_التاسع_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string : ");
            string inputString = Console.ReadLine();

            int count = 0;

            foreach (char c in inputString)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            Console.WriteLine("The number of capital letters in the string is: {0}", count);
            Console.ReadLine();
        }
    }
}
